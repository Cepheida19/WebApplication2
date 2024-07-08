namespace WebApplication2.ServicesLayer
{
    public interface ILogicService
    {
        void ProcessData(int number, string reply);

        int CompareAnswers(Dictionary<int, string> correctAnswers, Dictionary<int, string> receivedAnswers);
    }
}
