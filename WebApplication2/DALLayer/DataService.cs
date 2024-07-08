using WebApplication2.DataBase;

namespace WebApplication2.DALLayer
{
    public class DataService : IDataService
    {
        private readonly IQuestionAnswerRight _questionAnswerRight;
        private readonly IQuestionAnswerSave _questionAnswerSave;
        
        public DataService(IQuestionAnswerRight questionAnswerRight, IQuestionAnswerSave questionAnswerSave)
        {
            _questionAnswerRight = questionAnswerRight;
            _questionAnswerSave = questionAnswerSave;
        }
        public void SaveData(int number, string reply)
        {
            if (!_questionAnswerSave.QuestionsAnswers.ContainsKey(number)) {
                _questionAnswerSave.QuestionsAnswers.Add(number, reply);
            }
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
