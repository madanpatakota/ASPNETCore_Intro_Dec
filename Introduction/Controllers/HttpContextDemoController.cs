using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{



    [ApiController]
    [Route("api/[controller]")]
    public class HttpContextDemoController : ControllerBase
    {


        public HttpContextDemoController()
        {
            Console.WriteLine("HttpContextDemoController instantiated");
        }



        //[HttpPost]
        //[Route("ShowContext")]
        //public IActionResult ShowContext()
        //{

        //}



        [HttpPost("ShowContext/{Id}")]
        //[Route("ShowContext")]



        //Endpoint: https://locahost:7246/api/HttpContextDemo/ShowContext/5?age=25&location=NYC
        public IActionResult ShowContext
            (
                [FromRoute] int Id,                        //Route params
                [FromQuery]  int age,           //Query params
                [FromQuery] string location,  //Query params,
                [FromBody] UserDTO userDTO,
                [FromHeader(Name = "MyCollegeName")] string collegeName
            )
        {


           //var context = HttpContext;


           //var headers  =  context.Request.Headers;
           // var body     =  context.Request.Body;
           // var path     =  context.Request.Path;



          //context.Request.Body.
           



            //HttpContext.Response.Headers.Append("x-demo-response", "This is from Asp.netCore");
            //HttpContext.Response.Headers.Append("x-demo-MessageStatu", "Scussfull");



            return Ok(new
            {
                RouteId        = Id,
                QueryAge       = age,
                QueryLocation  = location,
                User           = userDTO,
                CollegeName    = collegeName,
                //RequestPath    = path,
                //RequestHeaders = headers.Keys,
            });




        }




    }



    public class  UserDTO
{
    public string Name { get; set; }
    public string Email { get; set; }
}


}
