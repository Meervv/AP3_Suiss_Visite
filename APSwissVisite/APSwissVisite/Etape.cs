namespace APSwissVisite
{
    public class Etape
    {
        public int Num;
        public string Libelle;

        public Etape(int num, string libelle)
        {
            Num = num;
            Libelle = libelle;
            Globale.Etapes[num] = this;
        }
    }
}
