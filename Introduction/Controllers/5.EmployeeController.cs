using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{


    // 10  values id , name , locaiton , slaary , phone number , age , emaildid .........

    [ApiController]
    [Route("api/[controller]")]     // https://localhost:7246/api/EmployeeV3/
    public class EmployeeV5Controller : ControllerBase
    {
        //public EmployeeV5Controller() { }


        //PUT 
        //if you want to update the recod 

        [HttpPut]

        [Route("UpdateEmployee/{Id}")]
        //endpoint : https://localhost:7246/api/EmployeeV5/UpdateEmployee/101

        //Put method is used to update the all in the record....
        public async Task<IActionResult> UpdateEmployee([FromRoute] int Id, [FromBody] EmployeeDTO employeeDTO)
        {
            //await Task.Delay(1000);

            var employeesList = await GetEmployees();

            //var employee = employeesList.Where(e => e.EmpId == Id).First();

            // employeesList.First(x => x.EmpId == Id);
            var employee = employeesList.FirstOrDefault(x => x.EmpId == Id);  // null

            //John Doe junior

            //    Hyderabad  , 50000

            if (employee != null)
            {
                employee.EmpLocation = employeeDTO.Location;
                employee.EmpName = employeeDTO.Name;
                employee.EmpSalary = employeeDTO.Salary;

                return Ok($"Employee has updated successfully Now {employee.EmpName} {employee.EmpSalary} {employee.EmpSalary}");
            }
            else
            {
                return BadRequest($"YOu are giving the wrong details. Please croos-check your requrest");

            }
        }






        [HttpPatch]
        [Route("UpdateEmployeeWithEmployeName/{Id}")]
        //endpoint : https://localhost:7246/api/EmployeeV5/UpdateEmployeeWithEmployeName/101

        //Put method is used to update the all in the record....
        public async Task<IActionResult> UpdateEmployeeWithEmployeName([FromRoute] int Id, [FromBody] UpdateEmployeeDTO employeeDTO)
        {
            //await Task.Delay(1000);

            var employeesList = await GetEmployees();

            //var employee = employeesList.Where(e => e.EmpId == Id).First();

            // employeesList.First(x => x.EmpId == Id);
            var employee = employeesList.FirstOrDefault(x => x.EmpId == Id);  // null

            //John Doe junior

            //    Hyderabad  , 50000

            if (employee != null)
            {
                //employee.EmpLocation = employeeDTO.Location;
                employee.EmpName = employeeDTO.EmpName;
                //employee.EmpSalary = employeeDTO.Salary;

                return Ok($"Employee has updated successfully Now {employee.EmpName} ");
            }
            else
            {
                return BadRequest($"YOu are giving the wrong details. Please croos-check your requrest");

            }
        }





        [HttpDelete]
        [Route("DeleteEmployee/{Id}")]
        //ht/s://localhost:7246/api/EmployeeV5/DeleteEmployee/101 
        public async Task<IActionResult> DeleteEmployee([FromRoute] int Id)
        {
            //await Task.Delay(1000);

            var employeesList = await GetEmployees();

            //var employee = employeesList.Where(e => e.EmpId == Id).First();

            // employeesList.First(x => x.EmpId == Id);
            var employee = employeesList.FirstOrDefault(x => x.EmpId == Id);  // null

            //John Doe junior

            //    Hyderabad  , 50000

            if (employee != null)
            {

                string[] names = ["Ravi", "ramu", "somu"];
                string name = "Ravi";
                var finalnames = names.Where(x => x != name);   // ramusomu



                employeesList.Remove(employee);
                ////employee.EmpLocation = employeeDTO.Location;
                //employee.EmpName = employeeDTO.EmpName;
                ////employee.EmpSalary = employeeDTO.Salary;

                return Ok($"Employee has delete and his id is  {employee.EmpId} ");
            }
            else
            {
                return BadRequest($"YOu are giving the wrong details. Please croos-check your requrest");

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
                new Employee(){ EmpId=105, EmpName="David Wilson", EmpLocation="New York", EmpSalary=55000 }
               // new Employee(){ EmpId=101, EmpName="David Wilson", EmpLocation="New York", EmpSalary=55000 }
            };
            return employees;
        }






    }


    //Domain models
    //public class Employee
    //{
    //    public int EmpId { get; set; }
    //    public string EmpName { get; set; }
    //    public string EmpLocation { get; set; }
    //    public double EmpSalary { get; set; }
    //}




    ////DTO - Data Transfer Object

    //public class EmployeeDTO
    //{

    //    public string Name { get; set; }

    //    public string Location { get; set; }

    //    public double Salary { get; set; }

    //}



    public class NewEmployeeResponeDTO
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }



    public class UpdateEmployeeDTO
    {
        ///public int EmpId { get; set; }
        public string EmpName { get; set; }
    }
}