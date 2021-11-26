using System.Data;
using System.Data.SqlClient;

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
        }
        public static void FetchFamilles()
        {
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

        #endregion

        #region Medicament Subroutines
        public static bool IsMedicamentValid(Medicament M)
        {
            return true;
            Connexion.Open();

            SqlCommand command = new SqlCommand("prc_medicament_derniereEtapeValide", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlParameter param = new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = M.DepotLegal };
            command.Parameters.Add(param); // Set le paramètre d'entrée
            SqlDataReader result = command.ExecuteReader();
            result.Read();
            Connexion.Close();
            return result.GetInt32(0) == 1;
        }

        public static int MedicamentGetLastEtape(Medicament M)
        {
            Connexion.Open();

            SqlCommand command = new SqlCommand("prc_medicament_getLastEtape", Connexion) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add(new SqlParameter("@depotLegal", SqlDbType.VarChar, 10, M.DepotLegal));
            SqlDataReader result = command.ExecuteReader();
            result.Read();
            Connexion.Close();
            return result.GetInt32(0);
        }
        #endregion

        #region Famille Subroutines        
        #endregion
    }
}
