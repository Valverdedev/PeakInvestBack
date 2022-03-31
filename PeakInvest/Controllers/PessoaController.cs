using Microsoft.AspNetCore.Mvc;
using PeakInvest.Interfaces;

namespace PeakInvest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        [HttpGet("{id}")]
        public KeyValuePair<int, string> Calcular(int id)
        {
            return _pessoaService.GetList(id);
        }
    }
}
