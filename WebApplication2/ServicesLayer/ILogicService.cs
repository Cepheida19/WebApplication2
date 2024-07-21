using WebApplication2.DALLayer.Models;

namespace WebApplication2.ServicesLayer
{
    public interface ILogicService
    {
        Task ProcessData(int number, string reply);
        int CompareAnswers(Dictionary<int, string> correctAnswers, Dictionary<int, string> receivedAnswers);
        Task SaveAnswerToDatabase(UserAnswers userAnswers);
        Task<int> CompareDatabaseAnswers();
    }
}
