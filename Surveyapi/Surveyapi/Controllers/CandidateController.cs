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
       
        private readonly IRepo<Candidate> _crepo;
        public CandidateController(IRepo<Candidate> crepo)
        {
            _crepo = crepo;
        }
        [HttpGet]
        [Route("Get_Candidates")]
        public async Task<ActionResult<IEnumerable<Candidate>>> GetAll()
        {
            var prd = _crepo.GetAll().ToList();
            if (prd.Count == 0)
                return NotFound("No Employee present");
            return Ok(prd);
        }
        [HttpPost]
        [Route("Add_Candidates")]
        public async Task<ActionResult<Candidate>> PostCandidate(Candidate candidate)
        {
            var can = await _crepo.Add(candidate);
            if (can == null)
            {
                return BadRequest("Something went wrong");
            }            
            return Created("Candidate Created", can);
        }
    }
}
