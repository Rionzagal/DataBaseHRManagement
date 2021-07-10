using FlamingSoftHR.Models;
using FlamingSoftHR.Server.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Models
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly ApplicationDbContext db;
        public EmployeesRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            //Get a list containing all of the instances of the employees. 
            return await db.Employees.ToListAsync();
        }

        public async Task<Employee> AddEmployee(Employee newEmployee)
        {
            //Create an instance of employee in the table employees. 
            var create = await db.Employees.AddAsync(newEmployee);
            await db.SaveChangesAsync();
            return create.Entity;
        }

        public async Task<Employee> GetEmployee(int EmployeeId)
        {
            //Get an instance of an employee in the table employees.
            return await db.Employees.FirstOrDefaultAsync(x => x.Id == EmployeeId);
        }

        public async Task<Employee> UpdateEmployee(Employee Employee)
        {
            //Update an instance of an employee in the table employees.
            var update = await db.Employees.FirstOrDefaultAsync(x => x.Id == Employee.Id);
            if (null != update)
            {
                update.FirstName = Employee.FirstName;
                update.MiddleName = Employee.MiddleName;
                update.LastName = Employee.LastName;
                update.Department = Employee.Department;
                update.EmployeeType = Employee.EmployeeType;

                await db.SaveChangesAsync();
                return update;
            }
            else
            {
                return null;
            }
        }

        public async Task<Employee> DeleteEmployee(int EmployeeId)
        {
            //Delete an instance of an employee in the table employees.
            var delete = await db.Employees.FirstOrDefaultAsync(x => x.Id == EmployeeId);
            if (null != delete)
            {
                db.Employees.Remove(delete);
                await db.SaveChangesAsync();
                return delete;
            }
            else
            {
                return null;
            }
        }

        public async Task<IEnumerable<Employee>> Search(string name, int? department, int? etype)
        {
            IQueryable<Employee> query = db.Employees;
            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(x => x.FirstName.Contains(name) 
                    || x.MiddleName.Contains(name) 
                    || x.LastName.Contains(name));   
            }

            if (null != department)
            {
                query = query.Where(x => x.Department == department);
            }

            if (null != etype)
            {
                query = query.Where(x => x.EmployeeType == etype);
            }

            return await query.ToListAsync();
        }
    }
}
