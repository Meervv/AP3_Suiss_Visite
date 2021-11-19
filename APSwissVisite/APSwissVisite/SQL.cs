using System.Data.SqlClient;

namespace APSwissVisite
{
    public static class SQL
    {
        // Propriété Data Source à changer /!\
        private const string ConnexionString = @"Data Source=BTS2020-17\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True";
        internal static SqlConnection Connexion = new SqlConnection(ConnexionString);

        //
        public static void lireLesEtapes()
        {
            //Globale.lesEtapes.Clear();

            Connexion.Open();
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeToutesEtapes", Connexion);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                int numEtape = int.Parse(SqlExec["num"].ToString());
                string libelleEtape = SqlExec["libelle"].ToString();

                Etape lEtape = new Etape(numEtape, libelleEtape);

                Globale.lesEtapes.Add(lEtape);
            }
            Connexion.Close();
        }
    }

    
}
