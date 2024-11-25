using Microsoft.AspNetCore.Mvc;
using VotingManager.Business.Services;
using VotingManager.Model.Elections;

namespace VotingManager.UI.WebApp.Controllers
{
    [ApiController]
    [Route("api/votos")]
    public class VotoController : ControllerBase
    {
        private readonly VotoService _votoService;

        public VotoController(VotoService votoService)
        {
            _votoService = votoService;
        }

        [HttpPost]
        public IActionResult RegistrarVoto([FromBody] Voto voto)
        {
            try
            {
                _votoService.RegistrarVoto(voto);
                return Ok("Voto registrado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
