using WebApplication2.DALLayer;

namespace WebApplication2.ServicesLayer
{
    public class LogicService : ILogicService
    {
        private readonly IDataService _dataService;

        public LogicService(IDataService dataService) {
            _dataService = dataService;
        }
        public void ProcessData(int number, string reply) {
            _dataService.SaveData(number, reply);
        }
        public int CompareAnswers(Dictionary<int, string> correctAnswers, Dictionary<int, string> receivedAnswers)
        {
            int count = 0;
            int result = 0;

            foreach (var kvp in correctAnswers)
            {
                if (receivedAnswers.TryGetValue(kvp.Key, out string value) && value == kvp.Value)
                {
                    count++;
                }
            }
            if (correctAnswers.Count != 0)
            {
                result = (count * 100) / correctAnswers.Count;
            }

            return result;
        }
    }
}
