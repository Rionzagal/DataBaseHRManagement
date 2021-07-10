using FlamingSoftHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Models
{
    public interface IEmployeeTypeRepository
    {
        Task<IEnumerable<EmployeeType>> GetEmployeeTypes();
        Task<EmployeeType> AddEmployeeType(EmployeeType newEmployeeType);
        Task<EmployeeType> GetEmployeeType(int eTypeId);
        Task<EmployeeType> UpdateEmployeeType(EmployeeType EmployeeType);
        Task<EmployeeType> DeleteEmployeeType(int eTypeId);
    }
}
