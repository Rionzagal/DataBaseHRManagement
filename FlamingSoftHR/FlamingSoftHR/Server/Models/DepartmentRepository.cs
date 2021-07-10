using FlamingSoftHR.Models;
using FlamingSoftHR.Server.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Models
{
    public class DepartmentRepository: IDepartmentRepository
    {
        private readonly ApplicationDbContext db;
        public DepartmentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            //Get a list containing all of the table instances
            return await db.Departments.ToListAsync();
        }

        public async Task<Department> AddDepartment(Department newDepartment)
        {
            //Create an instance of a department in the table Departments
            var create = await db.Departments.AddAsync(newDepartment);
            await db.SaveChangesAsync();
            return create.Entity;
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            //Read an instance of a department in the table Departments
            return await db.Departments.FirstOrDefaultAsync(x => x.Id == departmentId);
        }

        public async Task<Department> UpdateDepartment(Department department)
        {
            //Update an instance of a department in the table Departments
            var update = await db.Departments.FirstOrDefaultAsync(x => x.Id == department.Id);

            if (null != update)
            {
                update.Name = department.Name;
                await db.SaveChangesAsync();
                return update;
            }
            else
            {
                return null;
            }
        }

        public async Task<Department> DeleteDepartment(int departmentId)
        {
            //Delete an instance of a department in the table Departmetns
            var delete = await db.Departments.FirstOrDefaultAsync(x => x.Id == departmentId);
            if (null != delete)
            {
                db.Departments.Remove(delete);
                await db.SaveChangesAsync();
                return delete;
            }
            else
            {
                return null;
            }
        }
    }
}
