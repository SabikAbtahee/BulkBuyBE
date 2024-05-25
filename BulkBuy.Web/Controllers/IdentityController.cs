using Microsoft.AspNetCore.Mvc;

namespace BulkBuy.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IdentityController : Controller
    {

        public IdentityController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
