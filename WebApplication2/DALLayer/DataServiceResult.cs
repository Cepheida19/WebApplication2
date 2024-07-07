using WebApplication2.DataBase;

namespace WebApplication2.DALLayer
{
    public class DataServiceResult : IDataServiceResult
    {
        private readonly IQuestionAnswerRight _questionAnswerRight;
        private readonly IQuestionAnswerSave _questionAnswerSave;
        public DataServiceResult(IQuestionAnswerRight questionAnswerRight, IQuestionAnswerSave questionAnswerSave)
        {
            _questionAnswerRight = questionAnswerRight;
            _questionAnswerSave = questionAnswerSave;
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
