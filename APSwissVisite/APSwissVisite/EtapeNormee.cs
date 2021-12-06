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
        private int index;
        public EtapeNormee(int num, string libelle, string laNorme, DateTime dateNorme) : base(num, libelle)
        {
            this.norme = laNorme;
            this.date = dateNorme;
        }

        public string getNorme() { return this.norme; }

        public void setNorme(string norme) { this.norme = norme; }

        public DateTime getDateNorme() { return this.date; }

        public void setDateNorme(DateTime date) { this.date = date; }

        public void setNum(string norme) { this.norme = norme; }

        public void setLibelle(DateTime date) { this.date = date; }

        public int getIndex() {  return this.index; }

        public void setIndex(int idx) { this.index = idx; }
    }
}
