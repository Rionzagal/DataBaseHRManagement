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
    public class LogTimeController
    {
        private readonly ApplicationDbContext db;

        public LogTimeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpPut("{Id}")]
        public async Task<LogTime> Put(int Id, [FromBody] LogTime log)
        {
            var edit = await db.LogTime.FindAsync(Id);
            if(null != edit)
            {
                edit.DateLogged = log.DateLogged;
                edit.Hours = log.Hours;
                edit.LogType = log.LogType;
                edit.LoggedEmployee = log.LoggedEmployee;
                await db.SaveChangesAsync();
            }
            return edit;
        }

        [HttpDelete]
        public async Task<LogTime> Delete(int Id)
        {
            var delete = await db.LogTime.FindAsync(Id);
            if(null != delete)
            {
                db.LogTime.Remove(delete);
                await db.SaveChangesAsync();
            }
            return delete;
        }

        [HttpPost]
        public async Task<LogTime> Post([FromBody] LogTime create)
        {
            create.Id = Guid.NewGuid();
            EntityEntry<LogTime> log = await db.LogTime.AddAsync(create);
            await db.SaveChangesAsync();
            return log.Entity;
        }

        [HttpGet]
        public async Task<IEnumerable<LogTime>> Get(DateTime date)
        {
            return await Task.Factory.StartNew<IEnumerable<LogTime>>(() =>
            {
                if (DateTime.Now == date)
                    return db.LogTime;
                else
                    return db.LogTime.Where(x => x.DateLogged.Equals(date));
            });
        }

        [HttpGet("{Id}")]
        public async Task<LogTime> Get(int Id)
        {
            return await db.LogTime.FindAsync(Id);
        }
    }
}
