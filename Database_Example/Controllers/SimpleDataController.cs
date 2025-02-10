using Database_Example.Model;
using Microsoft.AspNetCore.Mvc;

namespace Database_Example.Controllers
{
    public class SimpleDataController : Controller
    {
        private readonly SimpleDataService simpleDataService;

        public SimpleDataController(SimpleDataService _simpleDataService)
        {
            simpleDataService = _simpleDataService;
        }

        [HttpPost("AddSimpleData")]
        public async Task<ActionResult> AddSimpleData([FromBody] SimpleData simpleData)
        {
            await simpleDataService.AddSimpleData(simpleData);
            return Ok();
        }
    }
}
