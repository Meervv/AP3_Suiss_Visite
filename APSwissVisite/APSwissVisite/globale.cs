using System.Collections.Generic;

namespace APSwissVisite
{
    public static class Globale
    {
        public static List<Etape> Etapes = new List<Etape>(9) { null, null, null, null, null, null, null, null, null, null };
        public static Dictionary<string, Medicament> Medicaments = new Dictionary<string, Medicament>();
        public static Dictionary<string, Famille> Familles = new Dictionary<string, Famille>();
        public static List<Decision> Decisions = new List<Decision>();
    }
}
