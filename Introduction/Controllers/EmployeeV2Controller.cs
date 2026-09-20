using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeV2Controller : ControllerBase
    {
        //publie emp

        private InMemoryEmployeeRepositoty _MEmp;

        //                          repo = new EmployeeRepositoty();
        public EmployeeV2Controller(InMemoryEmployeeRepositoty repo) {
            _MEmp = repo;  // new EmployeeRepository();
        }



        //endpoint:  https://localhost:7246/api/EmployeeV1/GetAllElmployeesV2 
        [HttpGet]
        [Route("GetAllElmployeesV2")]
        public async Task<IActionResult> GetAllEmpV2()
        {
            //EmployeeRepositoty _repo =  new EmployeeRepositoty("", 0.909m);
            var result = _MEmp._employees();
            await Task.Delay(1000);
            return Ok(result);
        }
    }

    public class InMemoryEmployeeRepositoty
    {
        public InMemoryEmployeeRepositoty() { }

        //drawback incase if this constuctor having the paramters InMemoryEmployeeRepositoty(string A)
        //So i need to update all the refereces of the  InMemoryEmployeeRepositoty of the class.

        // So thats the reaons always we should foloow the DIP princples

        //High-level module should not be depends on the low level modules 
        //BOth sould be depends on the shared interface or  abstracion classes..


        public List<EmployeeV2> _employees()
        {
            return new List<EmployeeV2>
            {
                new EmployeeV2 { Id = 1, Name = "John", Department = "IT" },
                new EmployeeV2 { Id = 2, Name = "Sara", Department = "HR" }
            };
        }

    }


    public class EmployeeV2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }





}
