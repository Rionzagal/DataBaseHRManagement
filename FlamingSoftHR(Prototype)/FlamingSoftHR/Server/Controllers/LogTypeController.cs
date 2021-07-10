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
    public class LogTypeController
    {
        private readonly ApplicationDbContext db;

        public LogTypeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpPut("{Id}")]
        public async Task<LogType> Put(int Id, [FromBody] LogType log)
        {
            var edit = await db.LogType.FindAsync(Id);
            if(null != edit)
            {
                edit.Description = log.Description;
                await db.SaveChangesAsync();
            }
            return edit;
        }

        [HttpDelete]
        public async Task<LogType> Delete(int Id)
        {
            var delete = await db.LogType.FindAsync(Id);
            if(null != delete)
            {
                db.LogType.Remove(delete);
                await db.SaveChangesAsync();
            }
            return delete;
        }

        [HttpPost]
        public async Task<LogType> Post([FromBody] LogType create)
        {
            create.Id = Guid.NewGuid();
            EntityEntry<LogType> log = await db.LogType.AddAsync(create);
            await db.SaveChangesAsync();
            return log.Entity;
        }

        [HttpGet]
        public async Task<IEnumerable<LogType>> Get(string Description)
        {
            return await Task.Factory.StartNew<IEnumerable<LogType>>(() =>
            {
                if (string.IsNullOrEmpty(Description))
                    return db.LogType;
                else
                    return db.LogType.Where(x => x.Description.Contains(Description));
            });
        }

        [HttpGet("{Id}")]
        public async Task<LogType> Get(int Id)
        {
            return await db.LogType.FindAsync(Id);
        }
    }
}
