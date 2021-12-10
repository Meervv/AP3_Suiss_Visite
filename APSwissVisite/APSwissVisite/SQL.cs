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
        private const string ConnexionString = @"Data Source=BTS2020-17\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True";
        internal static SqlConnection Connexion = new SqlConnection(ConnexionString);

        //afficher les étapes dans la listView
        public static void lireLesEtapes()
        {
            Connexion.Open();
            //instruction Transac-SQL / procédure exécuté avec la BDD SQLServer
            SqlCommand maRequete = new SqlCommand("prc_listeToutesEtapes", Connexion);

            //Obtient la valeur de la procédure stockée
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;

            //fournit un moyen de lire les lignes de la table 
            SqlDataReader SqlExec = maRequete.ExecuteReader();

            //boucle de lecture des normes avec ajout dans la liste des étapes
            while (SqlExec.Read())
            {
                int numEtape = int.Parse(SqlExec["num"].ToString());
                string libelleEtape = SqlExec["libelle"].ToString();
                if (SqlExec["norme"].GetType() == typeof(DBNull))
                    new Etape(numEtape, libelleEtape);
                else
                {
                    string norme = (string)SqlExec["norme"];
                    DateTime dateNorme = DateTime.Parse(SqlExec["dateNorme"].ToString());
                    new EtapeNormee(numEtape, libelleEtape, norme, dateNorme);
                }
            }
            Connexion.Close();
        }

        //modifier la ligne modifiée et inséré dans la table Historique
        public static void updateEtape(string norme, DateTime date, int id)
        {
            Connexion.Open();
            SqlCommand maRequete = new SqlCommand("prc_updateEtapes", Connexion) { CommandType = CommandType.StoredProcedure };

            SqlParameter paramNorme = new SqlParameter("@norme", SqlDbType.VarChar, 100) { Value = norme };
            SqlParameter paramDate = new SqlParameter("@date", SqlDbType.DateTime) { Value = date };
            SqlParameter paramId = new SqlParameter("@id", SqlDbType.Int, 2) { Value = id };

            maRequete.Parameters.Add(paramNorme);
            maRequete.Parameters.Add(paramDate);
            maRequete.Parameters.Add(paramId);
            maRequete.ExecuteNonQuery();

            Connexion.Close();
        }

        //permet afficher la liste des familles dans la listView
        public static void afficherFamille()
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

                Famille laFamille = new Famille(codeFamille, libelleFamille, nbMedicAmm);

                Globale.lesFamilles.Add(codeFamille, laFamille);
            }
            Connexion.Close();
        }

        //afficher les médicaments avec comme paramètre le codeFamille
        public static List<Medicament> afficherMedicaments(string code)
        {
            Connexion.Open();

            SqlCommand maRequete = new SqlCommand("prc_afficherMedicament", Connexion);

            maRequete.CommandType = CommandType.StoredProcedure;

            SqlParameter paramNum = new SqlParameter("@codeFamille", SqlDbType.VarChar, 3) { Value = code };

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
                string prix = SqlExec["MED_PRIXECHANTILLON"].ToString();
                string derniereEtape = SqlExec["derniere_etape"].ToString();

                Medicament unMedicament = new Medicament(depotLegal, nomCommerc, compo, effets, contreindic, "0", 1, famCode);

                lesMedoc.Add(unMedicament);

            }
            Connexion.Close();
            return lesMedoc;
        }
    }
}
