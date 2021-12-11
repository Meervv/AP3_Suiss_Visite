using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    public sealed class Medicament
    {
        private string depotLegale;
        private string nomCommercial;
        private string composition;
        private string effets;
        private string contreIndication;
        private string amm;
        private int derniereEtape;
        public Famille laFamille;
        public List<Workflow> LesEtapes;

        public Workflow DerniereEtape => LesEtapes.Count == 0 ? null : LesEtapes[LesEtapes.Count - 1];  
        public Medicament(string leDepot, string leNom, string laCompo, string lesEffets, string contreIndi, string leAmm, int last, string code)
        {
            this.depotLegale = leDepot;
            this.nomCommercial = leNom;
            this.composition = laCompo;
            this.effets = lesEffets;
            this.contreIndication = contreIndi;
            this.amm = leAmm;
            this.derniereEtape = last;
            this.laFamille = Globale.lesFamilles[code];
            Globale.lesMedicaments.Add(leDepot, this);

        }

        public string getDepotLegale() { return this.depotLegale; }
        public string getNom() { return this.nomCommercial; }
        public string getCompo() { return this.composition; }
        
        public Famille getLaFamille() { return this.laFamille; }
        public string getEffets() { return this.effets; }
        public string getContreIndic() { return this.contreIndication; }
        public string getAmm() { return this.amm; }
        public int getDerniereEtape() { return this.derniereEtape; }

        public List<Workflow> GetWorkflows() { return this.LesEtapes; }
    }
}
