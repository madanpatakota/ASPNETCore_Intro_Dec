using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{


    [ApiController]
    [Route("api/[controller]")]     // https://localhost:7246/api/EmployeeV3/
    public class EmployeeV4Controller : ControllerBase
    {
        public EmployeeV4Controller() { }





        //inserting we will see


        //Httppost means you are passing the some data(body) throught url then you have to give the some response ...


        [HttpPost]
        [Route("GetEmployeesListBySampleEmployeeClassWithQuery")]
        // https://localhost:7246/api/EmployeeV3/GetEmployeesListBySampleEmployeeClassWithQuery
        public async Task<IActionResult> GetEmployeesListBySampleEmployeeClassWithQuery
           ([FromBody] EmployeeDTO empDTO)
        {
            // i am not inserting data. i am trhing to take the values from the body.......... and method is the post


            var employeesList = await GetEmployees();  // given the resoponse to the guy who asked the data
            var result = employeesList.Where(x => x.EmpLocation == empDTO.Location && x.EmpSalary >= empDTO.Salary && x.EmpName == empDTO.Name);
            if (!result.Any())
            {
                return NotFound($"No employees found with salary and location {empDTO.Location} - {empDTO.Location} ");   // 404 Not found
            }
            else
            {
                return Ok(result);
            }
        }






        [HttpPost]
        [Route("AddNewEmployee")]
        // https://localhost:7246/api/EmployeeV3/AddNewEmployee
        public async Task<IActionResult> AddNewEmployee
           ([FromBody] EmployeeDTO empDTO)
        {
            await Task.Delay(1000); // simulating some processing delay;
            if (empDTO == null)
            {
                return BadRequest("Employee data is null");
            }
            // Simulate adding the new employee (in a real application, you would save this to a database)
            //Employee newEmployee = new Employee()
            //{
            //    EmpId = 1,// Generating a random EmpId
            //    EmpName = empDTO.Name,
            //    EmpLocation = empDTO.Location,
            //    EmpSalary = empDTO.Salary
            //};



            NewEmployeeResponeDTO newEmployee = new NewEmployeeResponeDTO()
            {
                EmpId = new Random().Next(1000, 9999), // Generating a random EmpId
                EmpName = empDTO.Name
            };



            // Here you would typically add the newEmployee to your data store
            return Created("https://localhost:7246/api/EmployeeV3/AddNewEmployee", newEmployee);
        }


        //YOu are in bank ---> you are expecting the Cash    -- Not the movie ticket.


        //slip - refID


        [HttpPost]
        [Route("AddNewEmployee1")]
        // https://localhost:7246/api/EmployeeV3/AddNewEmployee1    // 
        public async Task<IActionResult> AddNewEmployee1
           ([FromBody] EmployeeDTO empDTO)
        {
            await Task.Delay(1000); // simulating some processing delay;

            NewEmployeeResponeDTO newEmployee = new NewEmployeeResponeDTO()
            {
                EmpId = new Random().Next(1000, 9999), // Generating a random EmpId
                EmpName = empDTO.Name
            };

            // Here you would typicalwly add the newEmployee to your data store
            return Ok("Success");  //Why   //200 bad reuat not found 
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
                new Employee(){ EmpId=105, EmpName="David Wilson", EmpLocation="New York", EmpSalary=55000 }
            };
            return employees;
        }


        public class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public string EmpLocation { get; set; }
            public double EmpSalary { get; set; }
        }



        public class EmployeeDTO
        {

            public string Name { get; set; }

            public string Location { get; set; }

            public double Salary { get; set; }

        }



        public class NewEmployeeResponeDTO
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
        }




    }
}