using Microsoft.AspNetCore.Mvc;
using PeakInvest.Interfaces;
using PeakInvest.Models;

namespace PeakInvest.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CalcularController : ControllerBase
    {
        private readonly ICalculoService _calculoService;

        public CalcularController(ICalculoService calculoService)
        {

            _calculoService = calculoService;
        }

        [HttpPost]
        public double Calcular([FromBody] CalculoModel calculoModel)
        {
            return _calculoService.Calcular(calculoModel);
        }


    }
}
