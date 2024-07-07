using WebApplication2.DataBase;

namespace WebApplication2.DALLayer
{
    public class DataService : IDataService
    {
        private readonly IQuestionAnswerSave _questionAnswerSave;
        public DataService(IQuestionAnswerSave questionAnswerSave)
        {
            _questionAnswerSave = questionAnswerSave;
        }
        public void SaveData(int number, string reply)
        {
            _questionAnswerSave.QuestionsAnswers.Add(number, reply);
        }
    }
}
