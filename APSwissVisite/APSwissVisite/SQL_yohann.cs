using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace APSwissVisite
{
    class SQL_yohann
    {
        private const string ConnexionString = @"Data Source=BTS2020-17\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True";
        internal static SqlConnection Connexion = new SqlConnection(ConnexionString);
        public static int MedicamentGetLastEtape(Medicament M)
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_medicament_getLastEtape", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlParameter param = new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = M.getDepotLegale() };
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
            command.Parameters.Add(new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = M.getDepotLegale() });
            command.ExecuteNonQuery();
            Connexion.Close();
        }

        public static void MedicamentUpdateLastEtape(Medicament M, bool decision, DateTime date)
        {
            Connexion.Open();

            SqlCommand command = new SqlCommand("prc_updateLastEtape", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlParameter param1 = new SqlParameter("@depotLegal", SqlDbType.VarChar, 10) { Value = M.getDepotLegale() };
            SqlParameter param2 = new SqlParameter("@decision", SqlDbType.Int) { Value = decision };
            SqlParameter param3 = new SqlParameter("@date", SqlDbType.DateTime) { Value = date };
            SqlParameter param4 = new SqlParameter("@numEtape", SqlDbType.Int) { Value = M.LesEtapes.Count + 1 };
            command.Parameters.AddRange(new SqlParameter[] { param1, param2, param3, param4 });
            command.ExecuteNonQuery();
            Connexion.Close();

            MedicamentIncrementLastEtape(M);
            GetMedicamentWorkflow(M);
            if (MedicamentGetLastEtape(M) == 8) FamilleIncrementCount(M.getLaFamille().getCode());

            Globale.lesMedicaments[M.getDepotLegale()] = MedicamentGetByDepotLegal(M.getDepotLegale());
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
            //MessageBox.Show(result.GetValue(7).GetType().Name.ToString());
            Medicament M = new Medicament(depotLegal, result.GetString(1), result.GetString(3), result.GetString(4), result.GetString(5), result.GetString(2), false);
            Connexion.Close();
            GetMedicamentWorkflow(M);
            return M;
        }

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

        public static void FamilleIncrementCount(string codeFamille)
        {
            Connexion.Open();
            SqlCommand command = new SqlCommand("prc_famille_increment", Connexion) { CommandType = CommandType.StoredProcedure };
            command.Parameters.Add(new SqlParameter("@codeFamille", SqlDbType.VarChar, 3) { Value = codeFamille });
            command.ExecuteNonQuery();
            Connexion.Close();
        }

        public static void GetMedicamentWorkflow(Medicament M)
        {
            bool shouldClose = Connexion.State == ConnectionState.Closed;
            if (shouldClose) Connexion.Open();

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
            if (shouldClose) Connexion.Close();
        }
    }
}
