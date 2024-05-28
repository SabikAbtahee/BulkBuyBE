using BulkBuy.Commands.Identity;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Identity.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class IdentityController : Controller
    {
        private readonly IMediator _mediatr;

        public IdentityController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpPost]
        public async Task<ActionResult> Login()
        {
            var p = await _mediatr.Send(new LoginCommand() { Email = "", Password = "" });
            return Ok(p);
        }

        [HttpPost]
        public async Task<ActionResult> Register()
        {
            var p = await _mediatr.Send(new RegistrationCommand() { });
            return Ok(p);
        }
    }
}
