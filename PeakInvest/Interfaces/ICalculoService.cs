using Microsoft.AspNetCore.Mvc;
using PeakInvest.Models;

namespace PeakInvest.Interfaces
{
    public interface ICalculoService
    {
        double Calcular(CalculoModel model);
    }
}
