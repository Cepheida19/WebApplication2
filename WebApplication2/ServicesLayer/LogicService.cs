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
    }
}
