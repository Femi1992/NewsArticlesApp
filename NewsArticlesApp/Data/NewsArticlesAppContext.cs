using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NewsArticlesApp.Models
{
    public class NewsArticlesAppContext : DbContext
    {
        public NewsArticlesAppContext (DbContextOptions<NewsArticlesAppContext> options)
            : base(options)
        {
        }

        public DbSet<NewsArticlesApp.Models.Article> Article { get; set; }
    }
}
