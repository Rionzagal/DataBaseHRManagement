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
    public class EmployeeTypeController
    {
        private readonly ApplicationDbContext db;

        public EmployeeTypeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpPut("{Id}")]
        public async Task<EmployeeType> Put(int Id, [FromBody] EmployeeType EType)
        {
            var edit = await db.EmployeeType.FindAsync(Id);
            if (null != edit)
            {
                edit.Description = EType.Description;
                await db.SaveChangesAsync();
            }
            return edit;
        }

        [HttpDelete]
        public async Task<EmployeeType> Delete(int Id)
        {
            var delete = await db.EmployeeType.FindAsync(Id);
            if (null != delete)
            {
                db.EmployeeType.Remove(delete);
                await db.SaveChangesAsync();
            }
            return delete;
        }

        [HttpPost]
        public async Task<EmployeeType> Post([FromBody] EmployeeType create)
        {
            create.Id = Guid.NewGuid();
            EntityEntry<EmployeeType> EType = await db.EmployeeType.AddAsync(create);
            await db.SaveChangesAsync();
            return EType.Entity;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeType>> Get(string Description)
        {
            return await Task.Factory.StartNew<IEnumerable<EmployeeType>>(() =>
            {
                if (string.IsNullOrEmpty(Description))
                    return db.EmployeeType;
                else
                    return db.EmployeeType.Where(x => x.Description.Contains(Description));
            });
        }

        [HttpGet("{Id}")]
        public async Task<EmployeeType> Get(int Id)
        {
            return await db.EmployeeType.FindAsync(Id);
        }
    }
}
