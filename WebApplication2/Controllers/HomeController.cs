using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticlesRepository repository;

        private readonly ILogger<ArticlesController> logger;

        public ArticlesController(ILogger<ArticlesController> _logger, IArticlesRepository _repository)
        {
            logger = _logger;
            repository = _repository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Article), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<Article>> FindById()
        {
            var item = await repository.GetAsync(1);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);

        }
    }
}
