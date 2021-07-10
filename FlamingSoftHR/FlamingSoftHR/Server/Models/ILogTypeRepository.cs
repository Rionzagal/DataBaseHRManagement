using FlamingSoftHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Models
{
    public interface ILogTypeRepository
    {
        Task<IEnumerable<LogType>> GetLogTypes();
        Task<LogType> AddLogType(LogType newLogType);
        Task<LogType> GetLogType(int lTypeId);
        Task<LogType> UpdateLogType(LogType LogType);
        Task<LogType> DeleteLogType(int lTypeId);
    }
}
