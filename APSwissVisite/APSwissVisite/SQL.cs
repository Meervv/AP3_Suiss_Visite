using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace APSwissVisite
{
    public static class SQL
    {
        // Propriété Data Source à changer /!\
        private const string ConnexionString = @"Data Source=BTS2020-12\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True";
        internal static SqlConnection Connexion = new SqlConnection(ConnexionString);

        #region Fetch Subroutines
        public static void FetchMedicaments()
        {
            Medicament.LesMedicaments.Clear();
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_fetch_medicaments", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                string depotLegal = (string)result["MED_DEPOTLEGAL"];
                string nomCommercial = (string)result["MED_NOMCOMMERCIAL"];
                string composition = (string)result["MED_COMPOSITION"];
                string effets = (string)result["MED_EFFETS"];
                string contreIndic = (string)result["MED_CONTREINDIC"];
                string codeFamille = (string)result["FAM_CODE"];

                new Medicament(depotLegal, nomCommercial, composition, effets, contreIndic, codeFamille);
            }

            Connexion.Close();

            foreach (Medicament M in Medicament.LesMedicaments.Values)
                GetMedicamentWorkflow(M); // Récupération des workflows
        }

        public static void FetchFamilles()
        {
            Famille.LesFamilles.Clear();
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_fetch_familles", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                string code = (string)result["FAM_CODE"];
                string libelle = (string)result["FAM_LIBELLE"];

                new Famille(code, libelle);
            }
            Connexion.Close();
        }

        public static void FetchDecisions()
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_fetch_decisions", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                int id  = (int)result["id"];
                string libelle = (string)result["libelle"];

                new Decision(id, libelle);
            }
            Connexion.Close();
        }

        public static void FetchEtapes()
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_fetch_etapes", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                int numEtape = (int)result["num"];
                //MessageBox.Show($"Log {numEtape}");
                string libelleEtape = (string)result["libelle"];
                if (result["norme"].GetType() == typeof(DBNull))
                {
                    new Etape(numEtape, libelleEtape);
                    //MessageBox.Show($"Non normée : {numEtape}");
                }
                else
                {
                    string norme = (string)result["norme"];
                    DateTime dateNorme = DateTime.Parse(result["dateNorme"].ToString());
                    new EtapeNormee(numEtape, libelleEtape, norme, dateNorme);
                    //MessageBox.Show($"Normée : {numEtape} ; {norme}");
                }
            }
            Connexion.Close();
        }

        #endregion

        #region Medicament Subroutines
        public static int MedicamentGetLastEtape(Medicament M)
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_medicament_getLastEtape", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlParameter param = new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = M.DepotLegal };
            command.Parameters.Add(param);
            SqlDataReader result = command.ExecuteReader();
            result.Read();
            int value = result.GetValue(0).GetType() == typeof(DBNull) ? 0 : result.GetInt32(0);
            Connexion.Close();
            return value;
        }

        public static void MedicamentIncrementLastEtape(Medicament M)
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_medicament_incrementLastEtape", Connexion) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add(new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = M.DepotLegal });
            command.ExecuteNonQuery();
            Connexion.Close();
        }

        public static void MedicamentUpdateLastEtape(Medicament M, bool decision, DateTime date)
        {
            Connexion.Open();

            SqlCommand command = new SqlCommand("prc_updateLastEtape", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlParameter param1 = new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = M.DepotLegal };
            SqlParameter param2 = new SqlParameter("@decision", SqlDbType.Int) { Value = decision };
            SqlParameter param3 = new SqlParameter("@date", SqlDbType.DateTime) { Value = date };
            SqlParameter param4 = new SqlParameter("@numEtape", SqlDbType.Int) { Value = M.LesEtapes.Count + 1 };
            command.Parameters.AddRange(new SqlParameter[] { param1, param2, param3, param4 });
            command.ExecuteNonQuery();
            Connexion.Close();

            MedicamentIncrementLastEtape(M);
            GetMedicamentWorkflow(M);
            if (MedicamentGetLastEtape(M) == 8) FamilleIncrementCount(M.Famille.Code);

            Medicament.LesMedicaments[M.DepotLegal] = MedicamentGetByDepotLegal(M.DepotLegal);
        }

        public static Medicament MedicamentGetByDepotLegal(string depotLegal)
        {
            Connexion.Open();

            SqlCommand command = new SqlCommand("prc_getMedicamentByDebot", Connexion) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add(new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = depotLegal });
            SqlDataReader result = command.ExecuteReader();
            if (!result.HasRows) return null;
            result.Read();
            Medicament M = new Medicament(depotLegal, result.GetString(1), result.GetString(3), result.GetString(4), result.GetString(5), result.GetString(2), false);
            Connexion.Close();
            GetMedicamentWorkflow(M);
            return M;
        }

        #endregion

        #region Etape Subroutines

        public static Etape GetEtapeByID(int id)
        {
            if (id == 0) return new Etape(0, "Aucune étape");
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_etape_getByID", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlParameter param = new SqlParameter("@id", SqlDbType.Int) { Value = id };
            command.Parameters.Add(param);
            SqlDataReader result = command.ExecuteReader();
            result.Read();
            Etape etape = new Etape(id, result.GetString(1));
            Connexion.Close();
            return etape;
        }

        #endregion

        #region Famille Subroutines

        public static void FamilleIncrementCount(string codeFamille)
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_famille_increment", Connexion);
            command.Parameters.Add(new SqlParameter("@codeFamille", SqlDbType.NVarChar, 3) { Value = codeFamille });
            command.ExecuteNonQuery();
            Connexion.Close();
        }

        #endregion

        #region Workflow Subroutines
        public static void GetMedicamentWorkflow(Medicament M)
        {
            bool shouldClose = Connexion.State == ConnectionState.Closed;
            if (shouldClose) Connexion.Open();

            List<Workflow> workflows = new List<Workflow>();

            SqlCommand command = new SqlCommand("prc_getMedicamentWorkflow", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlParameter param = new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = M.DepotLegal };
            command.Parameters.Add(param);

            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                DateTime dateDecision = DateTime.Parse(result["dateDecision"].ToString());
                int numEtape = (int)result["numEtape"];
                int idDecision = (int)result["idDecision"];
                workflows.Add(new Workflow(M.DepotLegal, dateDecision, numEtape, idDecision));
            }

            M.LesEtapes = workflows;
            if (shouldClose) Connexion.Close();
        }
        #endregion
    }
}