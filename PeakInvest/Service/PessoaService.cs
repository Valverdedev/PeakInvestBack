using PeakInvest.Interfaces;


namespace PeakInvest.Service
{
    public class PessoaService : IPessoaService
    {
        private List<KeyValuePair<int, string>> List = new List<KeyValuePair<int, string>>();
        public KeyValuePair<int, string> GetList(int id)
        {
            initList();

            return List.FirstOrDefault(kvp => kvp.Key == id);
        }
        void initList()
        {
            List.Add(new KeyValuePair<int, string>(1, "João"));
            List.Add(new KeyValuePair<int, string>(2, "Maria"));
            List.Add(new KeyValuePair<int, string>(3, "Ana"));

        }
    }
}
