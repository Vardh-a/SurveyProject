using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Surveyapi.Models;
using Surveyapi.Services;

namespace Surveyapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCors")]
    public class CandidateController : ControllerBase
    {
        private readonly CandidateRepo _crepo;
        public CandidateController(CandidateRepo crepo)
        {
            _crepo = crepo;
        }
        [HttpGet]
        [Route("Get_Candidates")]
        public async Task<IActionResult> GetCandidates()
        {
            var candidates = await _crepo.GetAll();
            return Ok(candidates);
        }
        [HttpPost]
        [Route("Add_Candidates")]
        public async Task<IActionResult> PostEmployees(Candidate candidate)
        {
            var can = await _crepo.Add(candidate);
            return Created("Employee Created", can);
        }
    }
}
