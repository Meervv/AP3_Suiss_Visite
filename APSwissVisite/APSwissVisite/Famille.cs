using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    public sealed class Famille
    {
        private string codeFamille;
        private string libelle;
        private int nbMedicamentAmm;
        public static Dictionary<string, Famille> LesFamilles = new Dictionary<string, Famille>();

        public Famille(string leCode, string leLibelle, int nbMedi)
        {
            this.codeFamille = leCode;
            this.libelle = leLibelle;
            this.nbMedicamentAmm = nbMedi;
            LesFamilles.Add(leCode, this);
        }

        public string getCode() { return this.codeFamille; }
        public string getLibelle() { return this.libelle; }
        public int getNbMedicamentAmm() { return this.nbMedicamentAmm; }
    }
}
