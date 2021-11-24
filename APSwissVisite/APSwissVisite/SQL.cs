using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                int normee = int.Parse(SqlExec["normee"].ToString());

                Etape lEtape = new Etape(numEtape, libelleEtape, normee);

                Globale.lesEtapes.Add(lEtape);
            }
            Connexion.Close();
        }

        public static void lireLesEtapesNormees()
        {
            //Globale.lesEtapes.Clear();

            Connexion.Open();
            //objet SQLCommand pour définir la procédure stockée à utiliser
            SqlCommand maRequete = new SqlCommand("prc_listeToutesEtapesNormee", Connexion);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            // exécuter la procedure stockée dans un curseur 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des clients avec ajout dans la collection
            while (SqlExec.Read())
            {
                string norme = SqlExec["norme"].ToString();
                DateTime dateNorme = DateTime.Parse(SqlExec["dateNorme"].ToString());

                //EtapeNormee lEtapeNormee = new EtapeNormee(numEtape, libelleEtape, normee, norme, dateNorme);

                Globale.lesEtapesNormee.Add(lEtapeNormee);
            }
            Connexion.Close();
        }
    }

    
}
