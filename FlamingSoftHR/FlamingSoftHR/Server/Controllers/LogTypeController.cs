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
    public class LogTypeController : ControllerBase
    {
        private readonly ILogTypeRepository logTRepo;

        public LogTypeController(ILogTypeRepository logTRepo)
        {
            this.logTRepo = logTRepo;
        }

        [HttpGet]
        public async Task<ActionResult> GetLogTypes()
        {
            try
            {
                return Ok(await logTRepo.GetLogTypes());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error retrieving the log-in types list from the database.");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<LogType>> GetLogType(int id)
        {
            try
            {
                var ltype = await logTRepo.GetLogType(id);
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
                    "There has been an error retrieving the requested log-in type from the database.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<LogType>> AddLogType(LogType newLType)
        {
            try
            {
                if (null == newLType)
                {
                    return BadRequest();
                }
                else
                {
                    var create = await logTRepo.AddLogType(newLType);
                    return CreatedAtAction(nameof(newLType), new { id = create.Id }, create);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error creating the specified log-in type from the database.");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<LogType>> UpdateLogType(int id, LogType ltype)
        {
            try
            {
                if (ltype.Id != id)
                {
                    return BadRequest("Log-in type ID mismatch!");
                }
                else
                {
                    var update = await logTRepo.GetLogType(id);
                    if (null == update)
                    {
                        return NotFound($"Log-in type with Id: {id} not found.");
                    }
                    else
                    {
                        return await logTRepo.UpdateLogType(ltype);
                    }
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error updating the specified log-in type from the database.");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<LogType>> DeleteLogType(int id)
        {
            try
            {
                var delete = await logTRepo.GetLogType(id);
                if (null == delete)
                {
                    return NotFound($"Log-in type with Id: {id} not found!");
                }
                else
                {
                    return await logTRepo.DeleteLogType(id);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error deleting the specified log-in type from the database.");
            }
        }
    }
}
