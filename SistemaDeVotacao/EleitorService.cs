using System.Linq;
using VotingManager.Model.Users;
using VotingManager.Persistence;

namespace VotingManager.Business.Services
{
    public class EleitorService
    {
        private readonly VotingContext _context;

        public EleitorService(VotingContext context)
        {
            _context = context;
        }

        public void RegistrarEleitor(Eleitor eleitor)
        {
            _context.Eleitores.Add(eleitor);
            _context.SaveChanges();
        }

        public bool ValidarEleitorParaVoto(int eleitorId)
        {
            var eleitor = _context.Eleitores.FirstOrDefault(e => e.Id == eleitorId);
            return eleitor != null && !eleitor.Votou;
        }
    }
}
