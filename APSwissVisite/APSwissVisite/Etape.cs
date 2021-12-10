using System.Windows.Forms;
using System.Collections.Generic;

namespace APSwissVisite
{
    public class Etape
    {
        public static List<Etape> LesEtapes = new List<Etape>(9) { null, null, null, null, null, null, null, null, null, null };

        public int Num;
        public string Libelle;

        public Etape(int num, string libelle)
        {
            (Num, Libelle) = (num, libelle);
            LesEtapes[num] = this;
        }
    }
}
