﻿using WebApplication2.DALLayer.Models;

namespace WebApplication2.DALLayer
{
    public class UserAnswersRepository : IUserAnswersRepository
    {
        private readonly DataContext _context;
        public UserAnswersRepository(DataContext context) {
            _context = context;
        }
        public void AddAnswer(UserAnswers userAnswers) {
            if (!_context.UserAnswersTable.Contains(userAnswers)) {
                _context.UserAnswersTable.Add(userAnswers);
            }
            _context.SaveChanges();
        }
        public IEnumerable<UserAnswers> GetAllUserAnswers()
        {
            return _context.UserAnswersTable;
        }

    }
}
