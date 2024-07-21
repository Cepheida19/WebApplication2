using WebApplication2.DALLayer.Models;

namespace WebApplication2.DALLayer
{
    public interface IRightAnswersRepository
    {
        Task<IEnumerable<RightAnswers>> GetAllRightAnswers();

    }
}
