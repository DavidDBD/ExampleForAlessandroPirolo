using System.Threading.Tasks;

namespace WebApplication2
{
    public class ArticlesRepository : IArticlesRepository
    {
        private readonly ArticlesContext articlesContext;

        public ArticlesRepository(ArticlesContext _articlesContext)
        {
            articlesContext = _articlesContext;
        }

        public async Task<Article> GetAsync(int id)
        {
            return await articlesContext.Articles.FindAsync(id);
        }
    }
}