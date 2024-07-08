namespace WebApplication2.DALLayer
{
    public interface IDataService
    {
        void SaveData(int number, string reply);
        Dictionary<int, string> GetCorrectAnswers();
        Dictionary<int, string> GetReceivedAnswers();
    }
}
