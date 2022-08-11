using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Surveyapi.Services;
using System.Collections.Generic;

namespace Surveyapi.Models
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCors")]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepo< Employee> _repo;
        public EmployeeController(IRepo<Employee> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("Get_Employee")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAll()
        {
            var prd = _repo.GetAll().ToList();
            if (prd.Count == 0)
                return NotFound("No Employee present");
            return Ok(prd);
        }
        [HttpPost]
        [Route("Add_Employee")]
        public async Task<ActionResult<Employee>> PostEmployees(Employee employee)
        {
            var emp = await _repo.Add(employee);
            if(emp == null)
            {
                return BadRequest("Something went wrong");
            }
            return Created("Candidate Entered", emp);
        }
    }
}
