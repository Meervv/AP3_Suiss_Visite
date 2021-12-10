using System;

namespace APSwissVisite
{
    public sealed class Workflow
    {
        public string MedDepotLegal;
        public DateTime DateDecision;
        public int NumEtape;
        public int IdDecision;

        public Workflow(string depot, DateTime dateDecision, int numEtape, int idDecision)
            => (MedDepotLegal, DateDecision, NumEtape, IdDecision) = (depot, dateDecision, numEtape, idDecision);
    }
}
