namespace WebApplication2.DataBase
{
    public class QuestionAnswerRight : IQuestionAnswerRight
    {
        public Dictionary<int, string> CorrectAnswers { get; }

        public QuestionAnswerRight()
        {
            CorrectAnswers = new Dictionary<int, string>();

            CorrectAnswers.Add(1, "222");
            CorrectAnswers.Add(2, "гипотенуза");
            CorrectAnswers.Add(3, "180");
            CorrectAnswers.Add(4, "50");
        }
    }
}
