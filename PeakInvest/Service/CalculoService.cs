using PeakInvest.Interfaces;
using PeakInvest.Models;

namespace PeakInvest.Service
{
    public class CalculoService : ICalculoService
    {
        public double Calcular(CalculoModel model)
        {

            return ((model.Parcelas * model.Valor) * 0.05) + (model.Parcelas * model.Valor);

        }

    }
}
