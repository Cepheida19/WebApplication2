using WebApplication2.DALLayer.Models;

namespace WebApplication2.DALLayer
{
    public class RightAnswersRepository : IRightAnswersRepository
    {
        private readonly DataContext _context;

        public RightAnswersRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RightAnswers>> GetAllRightAnswers()
        {
            return _context.RightAnswersTable;
        }
    }
}
