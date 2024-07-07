

namespace WebApplication2.DataBase
{
    public class QuestionAnswerSave : IQuestionAnswerSave
    {
        public Dictionary<int, string> QuestionsAnswers { get; set; }

        public QuestionAnswerSave()
        {
            QuestionsAnswers = new Dictionary<int, string>();
        }
    }
}
