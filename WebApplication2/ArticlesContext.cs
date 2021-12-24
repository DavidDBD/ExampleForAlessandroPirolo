using Microsoft.EntityFrameworkCore;

namespace WebApplication2
{
    public class ArticlesContext : DbContext
    {
        private readonly DbContextOptions<ArticlesContext> _options;

        public ArticlesContext(DbContextOptions<ArticlesContext> options) : base(options)
        {
            
        }

        public DbSet<Article> Articles { get; set; }
    }
}