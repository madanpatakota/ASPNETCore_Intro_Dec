using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeV1Controller : ControllerBase
    {


        //Addscoped , addsingleton , addtransient

        //publie emp

        private IEmployeeV2Repositoty _IEmpRepo;

        //                          repo = new EmployeeRepositoty();
        public EmployeeV1Controller(IEmployeeV2Repositoty repo) {
            _IEmpRepo = repo;  // new EmployeeRepository();
        }


        [HttpGet]
        [Route("GetAllElmployeesV2")]
        public async Task<IActionResult> GetAllEmp()
        {
            //EmployeeRepositoty _repo =  new EmployeeRepositoty("", 0.909m);
            var result = _IEmpRepo._employees();
            await Task.Delay(1000);
            return Ok(result);
        }
    }


    public interface IEmployeeV2Repositoty
    {
        List<EmployeeV2> _employees();
    }



    public class InMemoryEmployeeRepositoty : IEmployeeV2Repositoty
    {
        public InMemoryEmployeeRepositoty() { }


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
