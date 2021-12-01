using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    public sealed class EtapeNormee : Etape
    {
        public string Norme;
        public DateTime Date;

        public EtapeNormee(int num, string libelle, string norme, DateTime date) : base(num, libelle)
        {
            (Norme, Date) = (norme, date);
            LesEtapes.Add(this);
        }
    }
}
