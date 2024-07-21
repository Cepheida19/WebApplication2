using WebApplication2.DALLayer;
using WebApplication2.DALLayer.Models;

namespace WebApplication2.ServicesLayer
{
    public class LogicService : ILogicService
    {
        private readonly IUserAnswersRepository _userAnswersRepository;
        private readonly IRightAnswersRepository _rightAnswersRepository;

        public LogicService(IUserAnswersRepository userAnswersRepository, IRightAnswersRepository rightAnswersRepository) {
            _userAnswersRepository = userAnswersRepository;
            _rightAnswersRepository = rightAnswersRepository;
        }
        public async Task ProcessData(int number, string reply)
        {
            var answer = new UserAnswers { Id = number, Answers = reply };
            //var answerRigth = new RightAnswers { Id = number, Answers = reply };

            await _userAnswersRepository.AddAnswer(answer);
            //_userAnswersRepository.AddRightAnswer(answerRigth);
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
        public async Task SaveAnswerToDatabase(UserAnswers userAnswers)
        {
            await _userAnswersRepository.AddAnswer(userAnswers);
        }
        public async Task SaveRightAnswerToDatabase(RightAnswers rightAnswers)
        {
            //await _userAnswersRepository.AddRightAnswer(rightAnswers);
        }
        public async Task<int> CompareDatabaseAnswers()
        {
            var correctAnswers = (await _rightAnswersRepository.GetAllRightAnswers())
                .ToDictionary(ra => ra.Id, ra => ra.Answers);

            var userAnswers = (await _userAnswersRepository.GetAllUserAnswers())
                .ToDictionary(ua => ua.Id, ua => ua.Answers);

            return CompareAnswers(correctAnswers, userAnswers);
        }
    }
}
