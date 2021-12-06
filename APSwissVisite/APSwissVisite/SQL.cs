using System.Data.SqlClient;
using System;
using System.Data;

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
                string norme = SqlExec["norme"].ToString();
                DateTime dateNorme = DateTime.Parse(SqlExec["dateNorme"].ToString());

                Etape lEtape = new Etape(numEtape, libelleEtape);
                EtapeNormee lEtapeNormee = new EtapeNormee(numEtape, libelleEtape, norme, dateNorme);

                Globale.lesEtapes.Add(lEtape);
                Globale.lesEtapes.Add(lEtapeNormee);
                //Globale.lesEtapesNormee.Add(lEtapeNormee);
            }
            Connexion.Close();
        }

        public static void updateEtape(string norme, DateTime date, int id)
        {
            Connexion.Open();
            SqlCommand maRequete = new SqlCommand("prc_updateEtapes", Connexion) { CommandType = CommandType.StoredProcedure };
            
            SqlParameter paramNorme = new SqlParameter("@norme", SqlDbType.VarChar, 100) { Value = norme };
            SqlParameter paramDate = new SqlParameter("@date", SqlDbType.DateTime) { Value = date };
            SqlParameter paramId = new SqlParameter("@id", SqlDbType.Int, 5) { Value = id };

            maRequete.Parameters.Add(paramNorme);
            maRequete.Parameters.Add(paramDate);
            maRequete.Parameters.Add(paramId);
            maRequete.ExecuteNonQuery();

            Connexion.Close();
        }
    }
}
