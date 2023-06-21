using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Core_Test_DesignDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult ShowNumberInput(int num)
        {
            int sonay = num + 1;
            return Ok(sonay);
        }
    }
}
