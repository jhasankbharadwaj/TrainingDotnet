using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionControllerlearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John Doe", Gender = "Male", City = "New York", Age = 30, Department = "HR" },
            new Employee { Id = 2, Name = "Jane Smith", Gender = "Female", City = "Los Angeles", Age = 25, Department = "Finance" },
            new Employee { Id = 3, Name = "Mike Johnson", Gender = "Male", City = "Chicago", Age = 40, Department = "IT" }
        };
        [HttpGet("Name")]
        public string GetName()
        {
            return "Return from GetName";
        }
        [HttpGet("Details")]
        public Employee GetEmployeeDetails()
        {
            return new Employee()
            {
                Id = 1001,
                Name = "Anurag",
                Age = 28,
                City = "Mumbai",
                Gender = "Male",
                Department = "IT"
            };
        }
        [HttpGet("All")]
        public IActionResult GetAllEmployee()
        {
            return Ok(Employees);
        }
        //As the following method is going to return Ok, Internal Server Error and NotFound Result
        //So, we are using IActionResult as the return type of this method
        [HttpGet("{Id}")]
        public IActionResult GetEmployeeDetails(int Id)
        {
            try
            {
                //In Real-Time, you will get the data from the database
                //Here, we have hardcoded the data
                var listEmployees = new List<Employee>()
                {
                    new Employee(){ Id = 1001, Name = "Anurag", Age = 28, City = "Mumbai", Gender = "Male", Department = "IT" },
                    new Employee(){ Id = 1002, Name = "Pranaya", Age = 28, City = "Delhi", Gender = "Male", Department = "IT" },
                    new Employee(){ Id = 1003, Name = "Priyanka", Age = 27, City = "BBSR", Gender = "Female", Department = "HR"},
                };

                //Fetch the Employee Data based on the Employee Id
                var employee = listEmployees.FirstOrDefault(emp => emp.Id == Id);

                //If Employee Exists Return OK with the Employee Data
                if (employee != null)
                {
                    return Ok(employee);
                }
                else
                {
                    //If Employee Does Not Exists Return NotFound
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                // _logger.LogError(ex, "An error occurred while getting all employees.");

                // Return a 500 Internal Server Error status code
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

       

        [HttpPost("Posting")]
        public IActionResult postingResust([FromBody] Employee employee) {

            if (employee == null || string.IsNullOrEmpty(employee.Name))
            {
                // If the data is invalid, return a 400 Bad Request status with a custom message
                return BadRequest(new { Message = "Invalid employee data" }); // BadRequestObjectResult with data
            }
            // Assign a new ID to the employee
            employee.Id = Employees.Count + 1;
            // Add the employee to the list
            Employees.Add(employee);
            // Return a 201 Created status with a location header pointing to the newly created employee
            return CreatedAtAction(nameof(GetEmployeeDetails), new { id = employee.Id }, employee); // CreatedAtActionResult
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee employee)
        {
            // Validate the employee data
            if (employee == null || id != employee.Id)
            {
                // If the data is invalid, return a 400 Bad Request status with a custom message
                return BadRequest(new { Message = "Invalid employee data" }); // BadRequestObjectResult with data
            }
            // Find the existing employee with the specified ID
            var existingEmployee = Employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
            {
                // If the employee is not found, return a 404 Not Found status
                return NotFound(); // NotFoundResult
            }
            // Update the employee properties
            existingEmployee.Name = employee.Name;
            existingEmployee.Gender = employee.Gender;
            existingEmployee.City = employee.City;
            existingEmployee.Age = employee.Age;
            existingEmployee.Department = employee.Department;
            // Return a 204 No Content status to indicate that the update was successful
            return NoContent(); // NoContentResult
        }
    }
}
