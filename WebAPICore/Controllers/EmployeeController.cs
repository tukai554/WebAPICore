using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;

namespace WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

    [HttpGet]
    [Route("[action]")]
    [Route("api/Employee/GetEmployee")]
    public IEnumerable<Employee>GetEmployee()
        {
            return _employeeService.GetEmployee();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/AddEmployee")]
        public Employee AddEmployee(Employee employee)
        {
            
          return _employeeService.AddEmployee(employee);
                        
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/Employee/UpdateEmployee")]
        public Employee UpdateEmployee(Employee employee)
        {

            return _employeeService.UpdateEmployee(employee);

        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Employee/DeleteEmployee")]
        public Employee DeleteEmployee(int id)
        {

            return _employeeService.DeleteEmployee(id);

        }
    }
}
