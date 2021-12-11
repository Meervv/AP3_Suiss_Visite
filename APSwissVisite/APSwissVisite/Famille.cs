<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    public sealed class Famille
    {
=======
﻿namespace APSwissVisite
{
    public sealed class Famille
    {
        public string Code;
        public string Libelle;
        public int NbMedicamentAmm;

        public Famille(string leCode, string leLibelle, int nbMedi)
        {
            Code = leCode;
            Libelle = leLibelle;
            NbMedicamentAmm = nbMedi;
            Globale.Familles.Add(leCode, this);
        }
>>>>>>> Stashed changes
    }
}
