using System.Collections.Generic;

namespace APSwissVisite
{
    public sealed class Famille
    {
        public static Dictionary<string, Famille> LesFamilles = new Dictionary<string, Famille>();

        public string Code;
        public string Libelle;

        public Famille(string code, string libelle)
        {
            (Code, Libelle) = (code, libelle);
            LesFamilles.Add(code, this);
        }
    }
}
