using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace APSwissVisite
{
    class Globale
    {
        public static List<Etape> lesEtapes = new List<Etape>(9) { null, null, null, null, null, null, null, null, null, null };
        public static List<EtapeNormee> lesEtapesNormee = new List<EtapeNormee>();
        public static Dictionary<string, Medicament> lesMedicaments = new Dictionary<string, Medicament>();
        public static Dictionary<string, Famille> lesFamilles = new Dictionary<string, Famille>();
    }
}
