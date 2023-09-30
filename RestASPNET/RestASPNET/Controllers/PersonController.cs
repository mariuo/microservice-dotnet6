using Microsoft.AspNetCore.Mvc;

namespace RestASPNET.Controllers
{
    [ApiController]
    [Route("calculator")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

       
    }

}
