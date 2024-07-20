using WebApplication2.DALLayer.Models;

namespace WebApplication2.DALLayer
{
    public class DataService : IDataService
    {
        private readonly IUserAnswersRepository _userAnswersRepository;
        private readonly IRightAnswersRepository _rightAnswersRepository;

        public DataService(IUserAnswersRepository userAnswersRepository, IRightAnswersRepository rightAnswersRepository)
        {
            _userAnswersRepository = userAnswersRepository;
            _rightAnswersRepository = rightAnswersRepository;
    }
        public void SaveData(int number, string reply)
        {
            var answer = new UserAnswers { Id = number, Answers = reply };
            //var answerRigth = new RightAnswers { Id = number, Answers = reply };

            _userAnswersRepository.AddAnswer(answer);
            //_userAnswersRepository.AddRightAnswer(answerRigth);
        }
 
        public Dictionary<int, string> GetCorrectAnswersFromDatabase()
        {
            var rightAnswers = _rightAnswersRepository.GetAllRightAnswers();
            return rightAnswers.ToDictionary(ra => ra.Id, ra => ra.Answers);
        }
        public IEnumerable<UserAnswers> GetUserAnswers()
        {
            return _userAnswersRepository.GetAllUserAnswers();
        }
    }
}
