using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{


    [ApiController]
    [Route("api/[controller]")]     // https://localhost:7246/api/EmployeeV3/
    public class EmployeeV3Controller : ControllerBase
    {
        public EmployeeV3Controller() { }


        [HttpGet]
        [Route("GetEmployeeList")]   // https://localhost:7246/api/EmployeeV3/GetEmployeeList

        public async Task<IActionResult> GetEmployeeList()
        {
           var EmployeeList =   await GetEmployees();

            if(EmployeeList == null || EmployeeList.Count == 0)
            {
                return NotFound("No employees found");
            }
            else
            {
                return Ok(EmployeeList);
            }
        }





        [HttpGet]
        [Route("GetEmployeeListByID/{id:int}")]   // https://localhost:7246/api/EmployeeV3/GetEmployeeListByID/101

        public async Task<IActionResult> GetEmployeeListByID(int ID)
        {
            var EmployeeList = await GetEmployees();


            var emp =  EmployeeList.Where(emp => emp.EmpId == ID); 

            if (emp == null)
            {
                return NotFound("No employee found");
            }
            else
            {
                return Ok(emp);
            }
        }



        // select * from employees where empid = 101;

        [HttpGet]
        [Route("GetEmployeeListByEmpslalary/{salary:double}")]   // https://localhost:7246/api/EmployeeV3/GetEmployeeListByEmpslalary/60000

        public async Task<IActionResult> GetEmployeeListByEmpslalary(double salary)
        {
            var EmployeeList = await GetEmployees();


            var emp = EmployeeList.Where(emp => emp.EmpSalary > salary);

            if (emp == null)
            {
                return NotFound("No employee found");
            }
            else
            {
                return Ok(emp);
            }
        }





        [HttpGet]
        [Route("GetEmployeeListByEmpslalaryandID/{ID:int}/{salary:double}")]   //Param
        // https://localhost:7246/api/EmployeeV3/GetEmployeeListByEmpslalaryandID/101/60000

        public async Task<IActionResult> GetEmployeeListByEmpslalaryandID(int id , double salary)
        {
            var EmployeeList = await GetEmployees();


            var emp = EmployeeList.Where(emp => emp.EmpSalary >= salary && emp.EmpId == id );

            if (emp == null  || emp.Count() == 0)
            {
                return NotFound("No employee found");
            }
            else
            {
                return Ok(emp);
            }
        }






























        private async Task<List<Employee>> GetEmployees()
        {
            await Task.Delay(2000); // simulating data fetch delay
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ EmpId=101, EmpName="John Doe", EmpLocation="New York", EmpSalary=60000 },
                new Employee(){ EmpId=102, EmpName="Jane Smith", EmpLocation="Los Angeles", EmpSalary=75000 },
                new Employee(){ EmpId=103, EmpName="Mike Johnson", EmpLocation="Chicago", EmpSalary=50000 },
                new Employee(){ EmpId=104, EmpName="Emily Davis", EmpLocation="Houston", EmpSalary=80000 },
            };
            return employees;
        }




    }



    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpLocation { get; set; }
        public double EmpSalary { get; set; }
    }



}
