using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSwissVisite
{
    public sealed class Workflow
    {
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
    }
}
