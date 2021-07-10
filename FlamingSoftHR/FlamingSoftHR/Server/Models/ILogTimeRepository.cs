using FlamingSoftHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Models
{
    public interface ILogTimeRepository
    {
        Task<IEnumerable<LogTime>> Search(DateTime? date, int? employee, int? logtype);
        Task<IEnumerable<LogTime>> GetLogTimes();
        Task<LogTime> AddLogTime(LogTime newLogTime);
        Task<LogTime> GetLogTime(int LogTimeId);
        Task<LogTime> UpdateLogTime(LogTime LogTime);
        Task<LogTime> DeleteLogTime(int LogTimeId);
    }
}
