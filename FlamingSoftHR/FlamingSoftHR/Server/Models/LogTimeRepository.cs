using FlamingSoftHR.Models;
using FlamingSoftHR.Server.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Models
{
    public class LogTimeRepository : ILogTimeRepository
    {
        private readonly ApplicationDbContext db;
        public LogTimeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<LogTime>> GetLogTimes()
        {
            //Get a list containing all of the instances of the employees. 
            return await db.LogTimes.ToListAsync();
        }

        public async Task<LogTime> AddLogTime(LogTime newLogTime)
        {
            //Create an instance of employee in the table employees. 
            var create = await db.LogTimes.AddAsync(newLogTime);
            await db.SaveChangesAsync();
            return create.Entity;
        }

        public async Task<LogTime> GetLogTime(int LogTimeId)
        {
            //Get an instance of an employee in the table employees.
            return await db.LogTimes.FirstOrDefaultAsync(x => x.Id == LogTimeId);
        }

        public async Task<LogTime> UpdateLogTime(LogTime LogTime)
        {
            //Update an instance of an employee in the table employees.
            var update = await db.LogTimes.FirstOrDefaultAsync(x => x.Id == LogTime.Id);
            if (null != update)
            {
                update.DateLogged = LogTime.DateLogged;
                update.Hours = LogTime.Hours;
                update.LogType = LogTime.LogType;
                update.LoggedEmployee = LogTime.LoggedEmployee;

                await db.SaveChangesAsync();
                return update;
            }
            else
            {
                return null;
            }
        }

        public async Task<LogTime> DeleteLogTime(int LogTimeId)
        {
            //Delete an instance of an employee in the table employees.
            var delete = await db.LogTimes.FirstOrDefaultAsync(x => x.Id == LogTimeId);
            if (null != delete)
            {
                db.LogTimes.Remove(delete);
                await db.SaveChangesAsync();
                return delete;
            }
            else
            {
                return null;
            }
        }

        public async Task<IEnumerable<LogTime>> Search(DateTime? date, int? employee, int? logtype)
        {
            IQueryable<LogTime> query = db.LogTimes;
            if (DateTime.Today != date)
            {
                query = query.Where(x => x.DateLogged == date);
            }

            if (null != employee)
            {
                query = query.Where(x => x.LoggedEmployee == employee);
            }

            if (null != logtype)
            {
                query = query.Where(x => x.LogType == logtype);
            }

            return await query.ToListAsync();
        }
    }
}
