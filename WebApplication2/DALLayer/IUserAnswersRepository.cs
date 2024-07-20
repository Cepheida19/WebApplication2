using WebApplication2.DALLayer.Models;

namespace WebApplication2.DALLayer
{
    public interface IUserAnswersRepository
    {
        public void AddAnswer(UserAnswers userAnswers);
        IEnumerable<UserAnswers> GetAllUserAnswers();
    }
}
