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
    public class EmployeeTypeController : ControllerBase
    {
        private readonly IEmployeeTypeRepository eTypeRepo;

        public EmployeeTypeController(IEmployeeTypeRepository eTypeRepo)
        {
            this.eTypeRepo = eTypeRepo;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployeeTypes()
        {
            try
            {
                return Ok(await eTypeRepo.GetEmployeeTypes());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error retrieving the employee types list from the database.");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<EmployeeType>> GetEmployeeType(int id)
        {
            try
            {
                var etype = await eTypeRepo.GetEmployeeType(id);
                if (null == etype)
                {
                    return NotFound();
                }
                else
                {
                    return etype;
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error retrieving the requested employee type from the database.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeType>> AddEmployeeType(EmployeeType newEType)
        {
            try
            {
                if (null == newEType)
                {
                    return BadRequest();
                }
                else
                {
                    var create = await eTypeRepo.AddEmployeeType(newEType);
                    return CreatedAtAction(nameof(newEType), new { id = create.Id }, create);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error creating the specified employee type from the database.");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<EmployeeType>> UpdateEmployeeType(int id, EmployeeType emp)
        {
            try
            {
                if (emp.Id != id)
                {
                    return BadRequest("Employee type ID mismatch!");
                }
                else
                {
                    var update = await eTypeRepo.GetEmployeeType(id);
                    if (null == update)
                    {
                        return NotFound($"Employee type with Id: {id} not found.");
                    }
                    else
                    {
                        return await eTypeRepo.UpdateEmployeeType(emp);
                    }
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error updating the specified employee type from the database.");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<EmployeeType>> DeleteEmployeeType(int id)
        {
            try
            {
                var delete = await eTypeRepo.GetEmployeeType(id);
                if (null == delete)
                {
                    return NotFound($"Employee type with Id: {id} not found!");
                }
                else
                {
                    return await eTypeRepo.DeleteEmployeeType(id);
                }

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error deleting the specified employee type from the database.");
            }
        }
    }
}
