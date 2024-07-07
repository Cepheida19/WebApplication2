namespace WebApplication2.DALLayer
{
    public interface IDataServiceResult
    {
        Dictionary<int, string> GetCorrectAnswers();
        Dictionary<int, string> GetReceivedAnswers();
    }
}
