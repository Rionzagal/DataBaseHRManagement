using FlamingSoftHR.Models;
using FlamingSoftHR.Server.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Models
{
    public class EmployeeTypeRepository : IEmployeeTypeRepository
    {
        private readonly ApplicationDbContext db;
        public EmployeeTypeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<EmployeeType>> GetEmployeeTypes()
        {
            //Get a list containing all of the instances of the employee types. 
            return await db.EmployeeTypes.ToListAsync();
        }
        public async Task<EmployeeType> AddEmployeeType(EmployeeType newEmployeeType)
        {
            //Create an instance of Employee type in the table employee types. 
            var create = await db.EmployeeTypes.AddAsync(newEmployeeType);
            await db.SaveChangesAsync();
            return create.Entity;
        }
        public async Task<EmployeeType> GetEmployeeType(int eTypeId)
        {
            //Get an instance of an employee type in the table employee types.
            return await db.EmployeeTypes.FirstOrDefaultAsync(x => x.Id == eTypeId);
        }
        public async Task<EmployeeType> UpdateEmployeeType(EmployeeType EmployeeType)
        {
            //Update an instance of an employee type in the table employee types.
            var update = await db.EmployeeTypes.FirstOrDefaultAsync(x => x.Id == EmployeeType.Id);
            if (null != update)
            {
                update.Description = EmployeeType.Description;
                await db.SaveChangesAsync();
                return update;
            }
            else
            {
                return null;
            }
        }
        public async Task<EmployeeType> DeleteEmployeeType(int eTypeId)
        {
            //Delete an instance of an employee type in the table employee types.
            var delete = await db.EmployeeTypes.FirstOrDefaultAsync(x => x.Id == eTypeId);
            if (null != delete)
            {
                db.EmployeeTypes.Remove(delete);
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
