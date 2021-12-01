using System.Data.SqlClient;
using System.Data;

namespace APSwissVisite
{
    public static class SQL
    {
        // Propriété Data Source à changer /!\
        private const string ConnexionString = @"Data Source=BTS2020-06-2\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True";
        internal static SqlConnection Connexion = new SqlConnection(ConnexionString);

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
        }

        public static void AjoutMedicament(string tbDepotLegal, string tbNomCommercial, string cbCodeFamille, float tbPrixEchantillon, string rtbCompoMed, string rtbEffetMed, string rtbContreIndic )
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_ajout_medicament", Connexion);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@DepotLegal", SqlDbType.NVarChar, 10) { Value = tbDepotLegal };
            command.Parameters.Add(param);
            SqlParameter param2 = new SqlParameter("@NomCommercial", SqlDbType.NVarChar, 25) { Value = tbNomCommercial };
            command.Parameters.Add(param2);
            SqlParameter param3 = new SqlParameter("@CodeFamille", SqlDbType.NVarChar, 3) {  Value = cbCodeFamille };
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
                string libelle = (string)result["libelle"];

                new Decision(id, libelle);
            }
            Connexion.Close();
        }

        public static void FetchFamille()
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_all_Famille", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlDataReader result = command.ExecuteReader();

            while (result.Read())
            {
                string code = (string)result["FAM_CODE"];
                string libelle = (string)result["FAM_LIBELLE"];

                new Famille(code,  libelle);
            }
            Connexion.Close();
        }
    }
}
