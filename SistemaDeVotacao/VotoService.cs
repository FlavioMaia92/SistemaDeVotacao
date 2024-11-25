using System.Linq;
using VotingManager.Model.Elections;
using VotingManager.Persistence;

namespace VotingManager.Business.Services
{
    public class VotoService
    {
        private readonly VotingContext _context;

        public VotoService(VotingContext context)
        {
            _context = context;
        }

        public void RegistrarVoto(Voto voto)
        {
            var eleitor = _context.Eleitores.Find(voto.EleitorId);
            if (eleitor == null || eleitor.Votou)
                throw new Exception("Eleitor inválido ou já votou!");

            _context.Votos.Add(voto);
            eleitor.Votou = true;
            _context.SaveChanges();
        }

        public int ContarVotosPorCandidato(int candidatoId)
        {
            return _context.Votos.Count(v => v.CandidatoId == candidatoId);
        }
    }
}
