using System;

namespace APSwissVisite
{
    public sealed class EtapeNormee : Etape
    {
        public string Norme;
        public DateTime Date;

        public EtapeNormee(int num, string libelle, string laNorme, DateTime dateNorme) : base(num, libelle)
        {
            Norme = laNorme;
            Date = dateNorme;
        }
    }
}
