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

    public class EmployeeV2Controller
    {
        public EmployeeV2Controller() { }




        //https://localhost:7246/api/EmployeeV1   - endpoint   = http method + path


        /// api/EmployeeV1/GetEmployee1 ---- uri of resource-----
        [HttpGet]
        [Route("GetEmployee1")]   //https://localhost:7246/api/EmployeeV1/GetEmployee1
        public string GetEmployeeName_1()
        {
            return "John Doe";
        }




        /// api/EmployeeV1/GetEmployee2 ---- uri of resource-----
        [HttpGet]
        [Route("GetEmployee2")]  ////https://localhost:7246/api/EmployeeV1/GetEmployee2
        public string GetEmployeeName_2()
        {
            return "Peter";
        }



    }
}
