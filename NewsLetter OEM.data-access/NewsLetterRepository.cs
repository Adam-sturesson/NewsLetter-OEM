using Microsoft.EntityFrameworkCore;
using NewsLetter_OEM.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsLetter_OEM.data_access
{
    public class NewsLetterRepository : INewsLetterRepository
    {
        private readonly ApplicationDBContext _context;
        public NewsLetterRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<bool> IsAlreadyReceivingNewsLetters(string email)
        {
            List<NewsLetter> newsLetters = await _context.NewsLetter.ToListAsync();
            foreach(NewsLetter n in newsLetters)
            {
                if(n.Email == email)
                {
                    return true;
                }
            }
            return false;
        }


        public async Task RegisterForNewsLetter(NewsLetter letterData)
        {
            _context.NewsLetter.Add(letterData);
            await _context.SaveChangesAsync();
        }
    }
}
