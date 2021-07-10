using FlamingSoftHR.Models;
using FlamingSoftHR.Server.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Models
{
    public class LogTypeRepository : ILogTypeRepository
    {
        private readonly ApplicationDbContext db;
        public LogTypeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<LogType>> GetLogTypes()
        {
            //Get a list containing all of the instances of the log types. 
            return await db.LogTypes.ToListAsync();
        }

        public async Task<LogType> AddLogType(LogType newLogType)
        {
            //Create an instance of log type in the table log types. 
            var create = await db.LogTypes.AddAsync(newLogType);
            await db.SaveChangesAsync();
            return create.Entity;
        }

        public async Task<LogType> GetLogType(int lTypeId)
        {
            //Get an instance of an log type in the table log types.
            return await db.LogTypes.FirstOrDefaultAsync(x => x.Id == lTypeId);
        }

        public async Task<LogType> UpdateLogType(LogType LogType)
        {
            //Update an instance of an log type in the table log types.
            var update = await db.LogTypes.FirstOrDefaultAsync(x => x.Id == LogType.Id);
            if (null != update)
            {
                update.Description = LogType.Description;
                await db.SaveChangesAsync();
                return update;
            }
            else
            {
                return null;
            }
        }
                
        public async Task<LogType> DeleteLogType(int lTypeId)
        {
            //Delete an instance of an log type in the table log types.
            var delete = await db.LogTypes.FirstOrDefaultAsync(x => x.Id == lTypeId);
            if (null != delete)
            {
                db.LogTypes.Remove(delete);
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
