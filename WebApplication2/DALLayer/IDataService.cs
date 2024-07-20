using WebApplication2.DALLayer.Models;

namespace WebApplication2.DALLayer
{
    public interface IDataService
    {
        void SaveData(int number, string reply);
        Dictionary<int, string> GetCorrectAnswersFromDatabase();
        IEnumerable<UserAnswers> GetUserAnswers();
    }
}
