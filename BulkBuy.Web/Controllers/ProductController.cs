using BulkBuy.ProductFeature.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace BulkBuy.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductController : Controller
    {

        private readonly IMediator _mediatr;

        public ProductController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }


        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] AddProductCommand payload)
        {
            var p = await _mediatr.Send(payload);
            return Ok(p);
        }
    }
}

