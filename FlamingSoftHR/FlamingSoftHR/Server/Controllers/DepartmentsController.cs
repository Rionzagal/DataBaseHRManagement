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
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository DepartmentRepo;
        public DepartmentsController(IDepartmentRepository DepartmentRepo)
        {
            this.DepartmentRepo = DepartmentRepo;
        }

        [HttpGet]
        public async Task<ActionResult> GetDepartments()
        {
            try
            {
                return Ok(await DepartmentRepo.GetDepartments());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error retrieving the departments list from the database.");            
            }
        }
        
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            try
            {
                var department = await DepartmentRepo.GetDepartment(id);
                if(null == department)
                {
                    return NotFound();
                }
                else
                {
                    return department;
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error retrieving the requested department from the database.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Department>> AddDepartment(Department newDepartment)
        {
            try
            {
                if (null == newDepartment)
                {
                    return BadRequest();
                }
                else
                {
                    var create = await DepartmentRepo.AddDepartment(newDepartment);
                    return CreatedAtAction(nameof(GetDepartment), new { id = create.Id }, create);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error creating the specified department from the database.");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Department>> UpdateDepartment(int id, Department dep)
        {
            try
            {
                if(dep.Id != id)
                {
                    return BadRequest("Department ID mismatch!");
                }
                else
                {
                    var update = await DepartmentRepo.GetDepartment(id);
                    if (null == update)
                    {
                        return NotFound($"Department with Id: {id} not found.");
                    }
                    else
                    {
                        return await DepartmentRepo.UpdateDepartment(dep);
                    }
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error updating the specified department from the database.");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Department>> DeleteDepartment(int id)
        {
            try
            {
                var delete = await DepartmentRepo.GetDepartment(id);
                if (null == delete)
                {
                    return NotFound($"Department with Id: {id} not found!");
                }
                else
                {
                    return await DepartmentRepo.DeleteDepartment(id);
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
