using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    public sealed class Medicament
    {
        public static Dictionary<string, Medicament> LesMedicaments = new Dictionary<string, Medicament>();

        public string DepotLegal;
        public string NomCommercial;
        public string Composition;
        public string Effets;
        public string ContreIndications;
        public Famille Famille;
        public List<Workflow> LesEtapes;

        public Medicament(string depotLegal, string nomCommercial, string composition, string effets, string contreIndications, string codeFamille)
        {
            (DepotLegal, NomCommercial, Composition, Effets, ContreIndications) =
                (depotLegal, nomCommercial, composition, effets, contreIndications);
            Famille = Famille.LesFamilles[codeFamille];
            LesMedicaments.Add(depotLegal, this); //Ajout automatique du nouveau médicament crée dans le dico
        }


    }
}