﻿using WebApplication2.DALLayer.Models;

namespace WebApplication2.DALLayer
{
    public interface IUserAnswersRepository
    {
        Task AddAnswer(UserAnswers userAnswers);
        Task<IEnumerable<UserAnswers>> GetAllUserAnswers();
    }
}
