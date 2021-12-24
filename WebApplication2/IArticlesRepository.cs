using System.Threading.Tasks;

namespace WebApplication2
{
    public interface IArticlesRepository
    {
        Task<Article> GetAsync(int id);
    }
}