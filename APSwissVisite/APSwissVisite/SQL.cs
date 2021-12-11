using System.Data.SqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace APSwissVisite
{
    public static class SQL
    {
        // Propriété Data Source à changer /!\
        private const string ConnexionString = @"Data Source=BTS2020-12\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True";
        internal static SqlConnection Connexion = new SqlConnection(ConnexionString);

        #region Fetch

        //afficher les étapes dans la listView
        public static void FetchEtapes()
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_listeToutesEtapes", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                int numEtape = (int)result["num"];
                string libelleEtape = (string)result["libelle"];
                // On regarde si la collonne "norme" est nulle, si oui c'est une étape normale, sinon c'est
                // une étape normée
                if (result["norme"].GetType() == typeof(DBNull))
                    new Etape(numEtape, libelleEtape);
                else
                {
                    string norme = (string)result["norme"];
                    DateTime dateNorme = DateTime.Parse(result["dateNorme"].ToString());
                    new EtapeNormee(numEtape, libelleEtape, norme, dateNorme);
                }
            }
            Connexion.Close();
        }

        public static void FetchMedicaments()
        {
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

                new Medicament(depotLegal, nomCommercial, composition, effets, contreIndic, codeFamille); // Ajouté direct au dico
            }

            Connexion.Close();

            foreach (Medicament M in Globale.Medicaments.Values)
                GetMedicamentWorkflow(M);
        }
        public static void FetchDecisions()
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_fetch_decisions", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                int id = (int)result["id"];
                string libelle = (string)result["lbelle"];

                new Decision(id, libelle);
            }
            Connexion.Close();
        }

        public static void FetchFamilles()
        {
            Connexion.Open();

            SqlCommand maRequete = new SqlCommand("prc_afficherFamille", Connexion);
            maRequete.CommandType = CommandType.StoredProcedure;

            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des Famille avec ajout dans le dictionnaire
            while (SqlExec.Read())
            {
                string codeFamille = SqlExec["FAM_CODE"].ToString();
                string libelleFamille = SqlExec["FAM_LIBELLE"].ToString();
                int nbMedicAmm = int.Parse(SqlExec["FAM_NBMEDIC"].ToString());

                new Famille(codeFamille, libelleFamille, nbMedicAmm);
            }
            Connexion.Close();
        }

        #endregion

        #region Etape
        public static void UpdateEtape(string norme, DateTime date, int id)
        {
            Connexion.Open();
            SqlCommand maRequete = new SqlCommand("prc_updateEtapes", Connexion) { CommandType = CommandType.StoredProcedure };

            SqlParameter paramNorme = new SqlParameter("@norme", SqlDbType.VarChar, 100) { Value = norme };
            SqlParameter paramDate = new SqlParameter("@date", SqlDbType.DateTime) { Value = date };
            SqlParameter paramId = new SqlParameter("@id", SqlDbType.Int, 2) { Value = id };

            maRequete.Parameters.AddRange(new SqlParameter[] { paramNorme, paramDate, paramId });

            maRequete.ExecuteNonQuery();

            Connexion.Close();
        }

        #endregion

        #region Famille

        public static List<Medicament> GetFamilleMedicaments(string codeFamille)
        {
            Connexion.Open();

            SqlCommand maRequete = new SqlCommand("prc_afficherMedicament", Connexion) { CommandType = CommandType.StoredProcedure };

            SqlParameter paramNum = new SqlParameter("@codeFamille", SqlDbType.VarChar, 3) { Value = codeFamille };

            maRequete.Parameters.Add(paramNum);

            SqlDataReader SqlExec = maRequete.ExecuteReader();

            List<Medicament> lesMedoc = new List<Medicament>();
            while (SqlExec.Read())
            {
                string depotLegal = SqlExec["MED_DEPOTLEGAL"].ToString();
                string nomCommerc = SqlExec["MED_NOMCOMMERCIAL"].ToString();
                string famCode = SqlExec["FAM_CODE"].ToString();
                string compo = SqlExec["MED_COMPOSITION"].ToString();
                string effets = SqlExec["MED_EFFETS"].ToString();
                string contreindic = SqlExec["MED_CONTREINDIC"].ToString();

                Medicament unMedicament = new Medicament(depotLegal, nomCommerc, compo, effets, contreindic, famCode, false);

                lesMedoc.Add(unMedicament);

            }
            Connexion.Close();
            return lesMedoc;
        }
        
        public static void FamilleIncrementCount(string codeFamille)
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_famille_increment", Connexion) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add(new SqlParameter("@codeFamille", SqlDbType.VarChar, 3) { Value = codeFamille });
            command.ExecuteNonQuery();
            Connexion.Close();
        }

        #endregion

        #region Medicament
        public static void GetMedicamentWorkflow(Medicament M)
        {
            if (Connexion.State == ConnectionState.Closed) Connexion.Open();

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
                workflows.Add(new Workflow(dateDecision, numEtape, idDecision, M.DepotLegal));
            }
            M.LesEtapes = workflows;
            Connexion.Close();
        }
        public static void AjoutMedicament(string tbDepotLegal, string tbNomCommercial, string cbCodeFamille, float tbPrixEchantillon, string rtbCompoMed, string rtbEffetMed, string rtbContreIndic)
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_ajout_medicament", Connexion) { CommandType = CommandType.StoredProcedure };

            SqlParameter paramDepot = new SqlParameter("@DepotLegal", SqlDbType.NVarChar, 10) { Value = tbDepotLegal };
            SqlParameter paramNom = new SqlParameter("@NomCommercial", SqlDbType.NVarChar, 25) { Value = tbNomCommercial };
            SqlParameter paramCodeFamille = new SqlParameter("@CodeFamille", SqlDbType.NVarChar, 3) { Value = cbCodeFamille };
            SqlParameter paramPrix = new SqlParameter("@PrixEchantillion", SqlDbType.Real, 15) { Value = tbPrixEchantillon };
            SqlParameter paramCompo = new SqlParameter("@CompoMed", SqlDbType.NVarChar, 255) { Value = rtbCompoMed };
            SqlParameter paramEffet = new SqlParameter("@EffetMed", SqlDbType.NVarChar, 255) { Value = rtbEffetMed };
            SqlParameter paramContreIndic = new SqlParameter("@ContreIndic", SqlDbType.NVarChar, 255) { Value = rtbContreIndic };

            // Permet d'ajouter tous les paramètres d'un coup
            command.Parameters.AddRange(new SqlParameter[] { paramDepot, paramNom, paramCodeFamille, paramPrix, paramCompo, paramEffet, paramContreIndic });

            command.ExecuteNonQuery();
            Connexion.Close();
        }
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

            Globale.Medicaments[M.DepotLegal] = MedicamentGetByDepotLegal(M.DepotLegal);
        }

        public static Medicament MedicamentGetByDepotLegal(string depotLegal)
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_getMedicamentByDebot", Connexion) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add(new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = depotLegal });
            SqlDataReader result = command.ExecuteReader();
            result.Read();
            if (!result.HasRows)
            {
                Connexion.Close();
                return null;
            }
            Medicament M = new Medicament(depotLegal, result.GetString(1), result.GetString(3), result.GetString(4), result.GetString(5), result.GetString(2), false);
            Connexion.Close();
            GetMedicamentWorkflow(M);
            return M;
        }

        #endregion
    }
}
