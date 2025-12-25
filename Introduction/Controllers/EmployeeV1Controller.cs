using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeV1Controller : ControllerBase
    {

        //publie emp
        public EmployeeV1Controller() { }


        [HttpGet]
        [Route("GetAllElmployees")]
        public async Task<IActionResult> GetAllEmp()
        {
            EmployeeRepositoty _repo =  new EmployeeRepositoty("", 0.909m);
            var result = _repo._employees();
            await Task.Delay(1000);
            return Ok(result);
        }
    }



    public class  EmployeeRepositoty
    {
        public EmployeeRepositoty(string abc , decimal afasdfa) { }


        public List<Employee> _employees()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "John", Department = "IT" },
                new Employee { Id = 2, Name = "Sara", Department = "HR" }
            };
        }

    }


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }





}
