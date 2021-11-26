using System.Collections.Generic;

namespace APSwissVisite
{
    public sealed class Decision
    {
        public static List<Decision> LesDecisions = new List<Decision>();

        public int ID;
        public string Libelle;

        public Decision(int id, string libelle)
        {
            (ID, Libelle) = (id, libelle);
            LesDecisions.Add(this);
        }
    }
}
