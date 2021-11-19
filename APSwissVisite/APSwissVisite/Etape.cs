using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    public sealed class Etape
    {
        private int num;
        private string libelle;
        private List<EtapeNormee> lesEtapesNormees;

        public Etape(int num, string libelle)
        {
            this.num = num;
            this.libelle = libelle;
            this.lesEtapesNormees = new List<EtapeNormee>();
        }

        public int getNum() { return this.num; }

        public string getLibelle() { return this.libelle; }

        public List<EtapeNormee> getLesEtapesNormees() { return this.lesEtapesNormees; }
    }
}
