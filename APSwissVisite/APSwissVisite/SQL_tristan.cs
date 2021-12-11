using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace APSwissVisite
{
    public static class SQL_tristan
    {
        // Propriété Data Source à changer /!\
        private const string ConnexionString = @"Data Source=BTS2020-17\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True";
        internal static SqlConnection Connexion = new SqlConnection(ConnexionString);

        public static void FetchEtapes()
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_listeToutesEtapes", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                int numEtape = (int)result["num"];
                string libelleEtape = (string)result["libelle"];
                if (result["norme"].GetType() == typeof(DBNull))
                {
                    new Etape(numEtape, libelleEtape);
                }
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
            SqlCommand command = new SqlCommand("prc_fetch_medicaments", Connexion);
            command.CommandType = CommandType.StoredProcedure;
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

            foreach (Medicament M in Globale.lesMedicaments.Values)
            {
                GetMedicamentWorkflow(M);
            }
        }

        public static void AjoutMedicament(string tbDepotLegal, string tbNomCommercial, string cbCodeFamille, float tbPrixEchantillon, string rtbCompoMed, string rtbEffetMed, string rtbContreIndic)
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_ajout_medicament", Connexion);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@DepotLegal", SqlDbType.NVarChar, 10) { Value = tbDepotLegal };
            command.Parameters.Add(param);
            SqlParameter param2 = new SqlParameter("@NomCommercial", SqlDbType.NVarChar, 25) { Value = tbNomCommercial };
            command.Parameters.Add(param2);
            SqlParameter param3 = new SqlParameter("@CodeFamille", SqlDbType.NVarChar, 3) { Value = cbCodeFamille };
            command.Parameters.Add(param3);
            SqlParameter param4 = new SqlParameter("@PrixEchantillion", SqlDbType.Real, 15) { Value = tbPrixEchantillon };
            command.Parameters.Add(param4);
            SqlParameter param6 = new SqlParameter("@CompoMed", SqlDbType.NVarChar, 255) { Value = rtbCompoMed };
            command.Parameters.Add(param6);
            SqlParameter param7 = new SqlParameter("@EffetMed", SqlDbType.NVarChar, 255) { Value = rtbEffetMed };
            command.Parameters.Add(param7);
            SqlParameter param8 = new SqlParameter("@ContreIndic", SqlDbType.NVarChar, 255) { Value = rtbContreIndic };
            command.Parameters.Add(param8);

            command.ExecuteNonQuery();
            Connexion.Close();
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

        /*public static void FetchFamille()
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_all_Famille", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                string code = (string)result["FAM_CODE"];
                string libelle = (string)result["FAM_LIBELLE"];
                int nbMedic = (int)result["FAM_NBMEDIC"];

                new Famille(code, libelle, nbMedic);
                Globale.lesFamilles.Add()
            }
            Connexion.Close();
        }*/

        public static void FetchWorkFlow()
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_fetch_workflow", Connexion);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                DateTime datedecision = (DateTime)result["dateDecision"];
                int numetape = (int)result["numEtape"];
                int iddecision = (int)result["idDecision"];
                string depotlegal = (string)result["medDepotLegal"];

                new Workflow(datedecision, numetape, iddecision, depotlegal); // Ajouté direct au dico
            }

            Connexion.Close();
        }
        public static void GetMedicamentWorkflow(Medicament M)
        {
            if (Connexion.State == ConnectionState.Closed) Connexion.Open();

            List<Workflow> workflows = new List<Workflow>();

            SqlCommand command = new SqlCommand("prc_getMedicamentWorkflow", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlParameter param = new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = M.getDepotLegale() };
            command.Parameters.Add(param);

            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                DateTime dateDecision = DateTime.Parse(result["dateDecision"].ToString());
                int numEtape = (int)result["numEtape"];
                int idDecision = (int)result["idDecision"];
                workflows.Add(new Workflow(dateDecision, numEtape, idDecision, M.getDepotLegale()));
            }
            M.LesEtapes = workflows;
            Connexion.Close();
        }

        public static void FetchDecision()
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_fetch_decisions", Connexion);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {

                int iddecision = (int)result["id"];
                string libelledecision = (string)result["lbelle"];

                new Decision(iddecision, libelledecision); // Ajouté direct au dico
            }

            Connexion.Close();
        }
    }
}
