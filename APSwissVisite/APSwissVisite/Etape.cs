using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    public class Etape
    {
        public static List<Etape> LesEtapes = new List<Etape>();

        public int Num;
        public string Libelle;

        public Etape(int num, string libelle)
        {
            (Num, Libelle) = (num, libelle);
            LesEtapes.Add(this);
        }
    }
}
