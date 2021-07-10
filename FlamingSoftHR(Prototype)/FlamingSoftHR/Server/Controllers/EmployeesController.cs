using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.AspNetCore.Mvc;
using FlamingSoftHR.Server.Data;
using FlamingSoftHR.Shared.Models;

namespace FlamingSoftHR.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController
    {
        private readonly ApplicationDbContext db;

        public EmployeesController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpPut("{Id}")]
        public async Task<Employees> Put(int Id, [FromBody] Employees emp)
        {
            var edit = await db.Employees.FindAsync(Id);
            if (null != edit)
            {
                edit.UserId = emp.UserId;
                edit.FirstName = emp.FirstName;
                edit.MiddleName = emp.MiddleName;
                edit.LastName = emp.LastName;
                edit.Department = emp.Department;
                edit.EmployeeType = emp.EmployeeType;
                await db.SaveChangesAsync();
            }
            return edit;
        }

        [HttpDelete]
        public async Task<Employees> Delete(int Id)
        {
            var delete = await db.Employees.FindAsync(Id);
            if (null != delete)
            {
                db.Employees.Remove(delete);
                await db.SaveChangesAsync();
            }
            return delete;
        }

        [HttpPost]
        public async Task<Employees> Post([FromBody] Employees create)
        {
            create.Id = Guid.NewGuid();
            EntityEntry<Employees> emp = await db.Employees.AddAsync(create);
            await db.SaveChangesAsync();
            return emp.Entity;
        }

        [HttpGet]
        public async Task<IEnumerable<Employees>> Get(string UserId)
        {
            return await Task.Factory.StartNew<IEnumerable<Employees>>(() =>
            {
                if (string.IsNullOrEmpty(UserId))
                    return db.Employees;
                else
                    return db.Employees.Where(x => x.UserId.Contains(UserId));
            });
        }

        [HttpGet("{Id}")]
        public async Task<Employees> Get(int Id)
        {
            return await db.Employees.FindAsync(Id);
        }
    }
}
