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
    public class DepartmentController
    {
        private readonly ApplicationDbContext db;

        public DepartmentController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpPut("{Id}")]
        public async Task<Department> Put(int Id, [FromBody] Department Department)
        {
            var edit = await db.Department.FindAsync(Id);
            if (null != edit)
            {
                edit.Name = Department.Name;
                await db.SaveChangesAsync();
            }
            return edit;
        }

        [HttpDelete("{Id}")]
        public async Task<Department> Delete(int Id)
        {
            var delete = await db.Department.FindAsync(Id);
            if(null != delete)
            {
                db.Department.Remove(delete);
                await db.SaveChangesAsync();
            }
            return delete;
        }

        [HttpPost]
        public async Task<Department> Post([FromBody] Department create)
        {
            create.Id = Guid.NewGuid();
            EntityEntry<Department> Department = await db.Department.AddAsync(create);
            await db.SaveChangesAsync();
            return Department.Entity;
        }

        [HttpGet]
        public async Task<IEnumerable<Department>> Get(string Name)
        {
            return await Task.Factory.StartNew<IEnumerable<Department>>(() =>
            {
                if (string.IsNullOrEmpty(Name))
                    return db.Department;
                else
                    return db.Department.Where(x => x.Name.Contains(Name));
            });
        }

        [HttpGet("{Id}")]
        public async Task<Department> Get(int Id)
        {
            return await db.Department.FindAsync(Id);
        }
    }
}
