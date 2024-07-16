using WebApplication2.DALLayer.Models;
using WebApplication2.DataBase;

namespace WebApplication2.DALLayer
{
    public class DataService : IDataService
    {
        private readonly IQuestionAnswerRight _questionAnswerRight;
        private readonly IQuestionAnswerSave _questionAnswerSave;
        private readonly IUserAnswersRepository _userAnswersRepository;

        public DataService(IQuestionAnswerRight questionAnswerRight, IQuestionAnswerSave questionAnswerSave, IUserAnswersRepository userAnswersRepository)
        {
            _questionAnswerRight = questionAnswerRight;
            _questionAnswerSave = questionAnswerSave;
            _userAnswersRepository = userAnswersRepository;
        }
        public void SaveData(int number, string reply)
        {
            //if (!_questionAnswerSave.QuestionsAnswers.ContainsKey(number)) {
            //    _questionAnswerSave.QuestionsAnswers.Add(number, reply);
            //}
            var answer = new UserAnswers { Id = number, Answers = reply };
            _userAnswersRepository.AddAnswer(answer);
        }
        public Dictionary<int, string> GetCorrectAnswers()
        {
            return _questionAnswerRight.CorrectAnswers;
        }

        public Dictionary<int, string> GetReceivedAnswers()
        {
            return _questionAnswerSave.QuestionsAnswers;
        }
    }
}
