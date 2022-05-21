using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;

namespace WebAPICore.Services
{
    public class EmployeeService : IEmployeeService

    {
        APICoreDBContext _dbcontext;
        public EmployeeService(APICoreDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<Employee>GetEmployee()
        {
            var employee = _dbcontext.Employee.ToList();
            return employee;
        }
        public Employee AddEmployee(Employee employee)
        {
            if(employee!=null)
            {
                _dbcontext.Add(employee);
                _dbcontext.SaveChanges();
                return employee;
            }
            return null;
        }
        public Employee UpdateEmployee(Employee employee)
        {
                _dbcontext.Entry(employee).State = EntityState.Modified;
                _dbcontext.SaveChanges();
                 return employee;
        }
        public Employee DeleteEmployee(int id)
        {
            var employee = _dbcontext.Employee.FirstOrDefault(x => x.Id == id);
            _dbcontext.Entry(employee).State = EntityState.Deleted;
            _dbcontext.SaveChanges();
             return employee;
        }
    }
}
