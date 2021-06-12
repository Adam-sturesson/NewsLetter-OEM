using Microsoft.EntityFrameworkCore;
using NewsLetter_OEM.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsLetter_OEM.data_access
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {
            
        }

        public DbSet<NewsLetter> NewsLetter { get; set; }
    }
}
