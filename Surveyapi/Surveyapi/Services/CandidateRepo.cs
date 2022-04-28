using Surveyapi.Models;

namespace Surveyapi.Services
{
    public class CandidateRepo 
    {
        static List<Candidate> _candidates = new List<Candidate>();
        public async Task<Candidate> Add(Candidate item)
        {
            _candidates.Add(item);
            return item;
        }

        public async Task<ICollection<Candidate>> GetAll()
        {
            return _candidates;
        }
    }
}
