using Microsoft.AspNetCore.Mvc;

namespace LiveTest_week_4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // ✅ GET: api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var values = new List<string> { "value1", "value2", "value3" };
            return Ok(values);
        }
    }
}
