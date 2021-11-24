using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    class EtapeNormee : Etape
    {
        private string norme;
        private DateTime date;
        public EtapeNormee(int num, string libelle, int normee, string laNorme, DateTime dateNorme) : base(num, libelle, normee)
        {
            this.norme = laNorme;
            this.date = dateNorme;
        }

        public string getNorme() { return this.norme; }

        public DateTime getDateNorme() { return this.date; }

        public void setNum(string norme) { this.norme = norme; }

        public void setLibelle(DateTime date) { this.date = date; }
    }
}
