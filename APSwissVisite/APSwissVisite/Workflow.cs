using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    public sealed class Workflow
    {
<<<<<<< Updated upstream
=======
        public DateTime DateDecison;
        public int NumEtape;
        public int IdDecision;
        public string Depotlegal;

        public Workflow(DateTime datedecision, int numetape, int iddecision, string depotlegal)
        {
            DateDecison = datedecision;
            NumEtape = numetape;
            IdDecision = iddecision;
            Depotlegal = depotlegal;
        }

        public DateTime getDate() { return this.DateDecison; }
        public int getNum() { return this.NumEtape; }
        public int getId() { return this.IdDecision; }
        public string getDepotLegal() { return this.Depotlegal; }
>>>>>>> Stashed changes
    }
}
