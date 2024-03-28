using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private BarContext _barContext;

        public BeerController(BarContext barContext)
        {
            _barContext = barContext;
        }

        [HttpGet]
        public IEnumerable<Beer> Get() => _barContext.Beers.ToList();
    }
}
