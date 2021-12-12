using System.Collections.Generic;

namespace APSwissVisite
{
    public sealed class Medicament
    {
        public string DepotLegal;
        public string NomCommercial;
        public string Composition;
        public string Effets;
        public string ContreIndications;
        public Famille Famille;
        public List<Workflow> LesEtapes;

        public Workflow DerniereEtape => LesEtapes.Count == 0 ? null : LesEtapes[LesEtapes.Count - 1];
        public Medicament(string leDepot, string leNom, string laCompo, string lesEffets, string contreIndi, string code, bool toList = true)
        {
            DepotLegal = leDepot;
            NomCommercial = leNom;
            Composition = laCompo;
            Effets = lesEffets;
            ContreIndications = contreIndi;
            Famille = Globale.Familles[code];
            if (toList)
                Globale.Medicaments.Add(leDepot, this);
        }
    }
}
