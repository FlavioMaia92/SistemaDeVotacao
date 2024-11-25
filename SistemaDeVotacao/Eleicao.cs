using System;
using System.Collections.Generic;

namespace VotingManager.Model.Elections
{
    public class Eleicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativa { get; set; }
        public ICollection<Candidato> Candidatos { get; set; }
    }
}
