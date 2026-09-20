using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeV3Controller : ControllerBase
    {


        //Addscoped , addsingleton , addtransient

        //publie emp

        private IEmployeeV3Repositoty _IEmpRepo;

        //                          repo = new EmployeeRepositoty();
        public EmployeeV3Controller(IEmployeeV3Repositoty repo) {

            //_IEmpRepo = new EmployeeRepository();
            //Actually i do't want to create the instane like this. Lets asp.netcore take the respobileit while intilial load of the appplication .

            //        i mean i want to get the instance while my app is loaded. that lets asp.netcore wil give the instace for you .. how you can do that in the sence by using the 3 techniques.  

            _IEmpRepo = repo;  // new EmployeeRepository();
        }



        //endpoint:  https://localhost:7246/api/EmployeeV1/GetAllElmployeesV2 
        [HttpGet]
        [Route("GetAllElmployeesV2")]
        public async Task<IActionResult> GetAllEmpV2()
        {
            //EmployeeRepositoty _repo =  new EmployeeRepositoty("", 0.909m);
            var result = _IEmpRepo._employees();
            await Task.Delay(1000);  // Plz wait(await) for 1 sec please here 
            return Ok(result);
        }
    }


    public interface IEmployeeV3Repositoty
    {
        List<EmployeeV2> _employees();
    }



    public class InMemoryEmployeev3Repositoty : IEmployeeV3Repositoty
    {
        public InMemoryEmployeev3Repositoty() { }


        public List<EmployeeV2> _employees()
        {
            return new List<EmployeeV2>
            {
                new EmployeeV2 { Id = 1, Name = "John", Department = "IT" },
                new EmployeeV2 { Id = 2, Name = "Sara", Department = "HR" }
            };
        }

    }


    public class EmployeeV3
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }





}
