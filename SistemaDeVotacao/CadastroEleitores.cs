using Microsoft.AspNetCore.Mvc;
using VotingManager.Business.Services;
using VotingManager.Model.Users;

namespace VotingManager.UI.WebApp.Controllers
{
    [ApiController]
    [Route("api/eleitores")]
    public class EleitorController : ControllerBase
    {
        private readonly EleitorService _eleitorService;

        public EleitorController(EleitorService eleitorService)
        {
            _eleitorService = eleitorService;
        }

        [HttpPost]
        public IActionResult RegistrarEleitor([FromBody] Eleitor eleitor)
        {
            _eleitorService.RegistrarEleitor(eleitor);
            return Ok("Eleitor registrado com sucesso!");
        }
    }
}
