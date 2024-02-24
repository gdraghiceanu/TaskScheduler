using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TaskScheduler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> CreateTask ()
        {
            //data, url

            return null;
        }
    }
}
