using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    public sealed class Decision
    {
<<<<<<< Updated upstream
=======
        public int ID;
        public string Libelle;

        public Decision(int id, string libelle)
        {
            ID = id;
            Libelle = libelle;
            Globale.Decisions.Add(this);
        }
>>>>>>> Stashed changes
    }
}
