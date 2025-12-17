using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{

    // you have to desing the End point 


    // 1. desing the apicontroller attribute
    // 2. desing the route attribute to desing for the base path of the controller 

    //app-root
    //app-compa


    //app-compa

    //    app-compab

    //    app-compo

    //    app-custom


    //https://localhost:7246/EmployeeV1

    [ApiController]
    [Route("api/[controller]")]

    public class EmployeeV1Controller : ControllerBase
    {
        public EmployeeV1Controller() { }




        //https://localhost:7246/api/EmployeeV1   - endpoint   = http method + path


        /// api/EmployeeV1/GetEmployee1 ---- uri of resource-----
        [HttpGet]
        [Route("GetEmployee1")]   //https://localhost:7246/api/EmployeeV1/GetEmployee1
        public async Task<IActionResult> GetEmployeeName_1()
        {

            await Task.Delay(5000);   // just i am waiting for 5 second

            string empname = null;

            if(empname == null)
            {
                return BadRequest("No employee found");
            }
            else
            {
                return Ok("John Doe");
            }

                
        }




        /// api/EmployeeV1/GetEmployee1 ---- uri of resource-----
        //[HttpGet]
        //[Route("GetEmployee2")]  ////https://localhost:7246/api/EmployeeV1/GetEmployee2
        //public  string GetEmployeeName_2()
        //{
        //    return "Peter";
        //}



    }
}
