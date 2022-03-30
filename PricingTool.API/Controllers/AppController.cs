using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PricingTool.API.Controllers
{
    [Route("App/[action]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        public string Get()
        {
            return "test";
        }
    }
}
