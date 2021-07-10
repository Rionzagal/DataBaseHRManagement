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
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeesRepository EmployeeRepo;
        public EmployeeController(IEmployeesRepository EmployeeRepo)
        {
            this.EmployeeRepo = EmployeeRepo;
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<Employee>>> Search(string name, int? department, int? etype)
        {
            try
            {
                var result = await EmployeeRepo.Search(name, department, etype);
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
                    "There has been an error retrieving the employees list from the database.");
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                return Ok(await EmployeeRepo.GetEmployees());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error retrieving the employees list from the database.");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            try
            {
                var employee = await EmployeeRepo.GetEmployee(id);
                if (null == employee)
                {
                    return NotFound();
                }
                else
                {
                    return employee;
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error retrieving the requested employee from the database.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Department>> AddEmployee(Employee newEmployee)
        {
            try
            {
                if (null == newEmployee)
                {
                    return BadRequest();
                }
                else
                {
                    var create = await EmployeeRepo.AddEmployee(newEmployee);
                    return CreatedAtAction(nameof(GetEmployee), new { id = create.Id }, create);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error creating the specified employee from the database.");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee emp)
        {
            try
            {
                if (emp.Id != id)
                {
                    return BadRequest("Employee ID mismatch!");
                }
                else
                {
                    var update = await EmployeeRepo.GetEmployee(id);
                    if (null == update)
                    {
                        return NotFound($"Employee with Id: {id} not found.");
                    }
                    else
                    {
                        return await EmployeeRepo.UpdateEmployee(emp);
                    }
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "There has been an error updating the specified employee from the database.");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            try
            {
                var delete = await EmployeeRepo.GetEmployee(id);
                if (null == delete)
                {
                    return NotFound($"Employee type with Id: {id} not found!");
                }
                else
                {
                    return await EmployeeRepo.DeleteEmployee(id);
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
