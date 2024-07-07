namespace WebApplication2.ServicesLayer
{
    public interface ILogicCompareService
    {
        int CompareAnswers(Dictionary<int, string> correctAnswers, Dictionary<int, string> receivedAnswers);
    }
}
