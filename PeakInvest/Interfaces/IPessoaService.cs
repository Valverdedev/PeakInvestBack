using PeakInvest.ViewModel;

namespace PeakInvest.Interfaces
{
    public interface IPessoaService
    {
        KeyValuePair<int, string> GetList(int id);
    }
}
