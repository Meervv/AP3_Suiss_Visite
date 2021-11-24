using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    class Etape
    {
        private int num;
        private string libelle;
        private int estNormee;
        private List<EtapeNormee> lesEtapesNormees;

        public Etape(int num, string libelle, int estNormee)
        {
            this.num = num;
            this.libelle = libelle;
            this.estNormee = estNormee;
            this.lesEtapesNormees = new List<EtapeNormee>();
        }

        public int getNum() { return this.num; }

        public string getLibelle() { return this.libelle; }

        public int getEstNormee() { return this.estNormee; }

        public List<EtapeNormee> getLesEtapesNormees() { return this.lesEtapesNormees; }
    }
}
