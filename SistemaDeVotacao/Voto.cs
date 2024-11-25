using System;

namespace VotingManager.Model.Elections
{
    public class Voto
    {
        public int Id { get; set; }
        public int EleitorId { get; set; }
        public Eleitor Eleitor { get; set; }
        public int CandidatoId { get; set; }
        public Candidato Candidato { get; set; }
        public DateTime DataHora { get; set; }
    }
}
