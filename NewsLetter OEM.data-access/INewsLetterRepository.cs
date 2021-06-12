using NewsLetter_OEM.models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewsLetter_OEM.data_access
{
    public interface INewsLetterRepository
    {
        Task<bool> IsAlreadyReceivingNewsLetters(string email);

        Task RegisterForNewsLetter(NewsLetter letterData);
    }
}
