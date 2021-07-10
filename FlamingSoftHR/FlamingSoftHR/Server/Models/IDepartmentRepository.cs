using FlamingSoftHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Models
{
    public interface IDepartmentRepository
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> AddDepartment(Department newDepartment);
        Task<Department> GetDepartment(int departmentId);
        Task<Department> UpdateDepartment(Department department);
        Task<Department> DeleteDepartment(int departmentId);
    }
}
