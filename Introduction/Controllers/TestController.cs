using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{


    //https://localhost:7246/api/Test/GetTestData
    //http://locahost:7246/api/Test/GetTestData
    //http://locahost:7246/api/Test/GetTestData

    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        public TestController()
        {
            Console.WriteLine("TestController instantiated");
        }


        [HttpGet]
        [Route("GetTestData")]
        public IActionResult GetTestData()
        {
            return Ok("This is test data from TestController");
        }



    }
}
