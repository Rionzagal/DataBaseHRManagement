using FlamingSoftHR.Models;
using FlamingSoftHR.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogTimeController : ControllerBase
    {
        private readonly ILogTimeRepository ltRepo;
        public LogTimeController(ILogTimeRepository ltRepo)
        {
            this.ltRepo = ltRepo;
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<LogTime>>> Search(DateTime? date, int? employee, int? logtype)
        {
            try
            {
                var result = await ltRepo.Search(date, employee, logtype);
                if (result.Any())
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error retrieving the log-in list from the database.");
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetLogTimes()
        {
            try
            {
                return Ok(await ltRepo.GetLogTimes());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error retrieving the log-in list from the database.");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<LogTime>> GetLogTime(int id)
        {
            try
            {
                var ltype = await ltRepo.GetLogTime(id);
                if (null == ltype)
                {
                    return NotFound();
                }
                else
                {
                    return ltype;
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error retrieving the requested log-in from the database.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<LogTime>> AddLogTime(LogTime newLTime)
        {
            try
            {
                if (null == newLTime)
                {
                    return BadRequest();
                }
                else
                {
                    var create = await ltRepo.AddLogTime(newLTime);
                    return CreatedAtAction(nameof(newLTime), new { id = create.Id }, create);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error creating the specified log-in from the database.");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<LogTime>> UpdateLogTime(int id, LogTime lt)
        {
            try
            {
                if (lt.Id != id)
                {
                    return BadRequest("Log-in ID mismatch!");
                }
                else
                {
                    var update = await ltRepo.GetLogTime(id);
                    if (null == update)
                    {
                        return NotFound($"Log-in with Id: {id} not found.");
                    }
                    else
                    {
                        return await ltRepo.UpdateLogTime(lt);
                    }
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error updating the specified log-in from the database.");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<LogTime>> DeleteLogTime(int id)
        {
            try
            {
                var delete = await ltRepo.GetLogTime(id);
                if (null == delete)
                {
                    return NotFound($"Log-in type with Id: {id} not found!");
                }
                else
                {
                    return await ltRepo.DeleteLogTime(id);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error deleting the specified log-in from the database.");
            }
        }
    }
}
