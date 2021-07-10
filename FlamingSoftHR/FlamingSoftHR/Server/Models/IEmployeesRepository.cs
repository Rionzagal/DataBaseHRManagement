using FlamingSoftHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Models
{
    public interface IEmployeesRepository
    {
        Task<IEnumerable<Employee>> Search(string name, int? department, int? etype);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> AddEmployee(Employee newEmployee);
        Task<Employee> GetEmployee(int EmployeeId);
        Task<Employee> UpdateEmployee(Employee Employee);
        Task<Employee> DeleteEmployee(int EmployeeId);
    }
}
