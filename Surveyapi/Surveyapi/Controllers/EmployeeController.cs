using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Surveyapi.Services;

namespace Surveyapi.Models
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCors")]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepo<int, Employee> _repo;
        public EmployeeController(IRepo<int, Employee> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("Get_Employee")]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _repo.GetAll();
            return Ok(employees);
        }
        [HttpPost]
        [Route("Add_Employee")]
        public async Task<IActionResult> PostEmployees(Employee employee)
        {
            var emp = await _repo.Add(employee);
            return Created("Candidate Entered", emp);
        }
    }
}
