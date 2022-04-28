using Surveyapi.Models;

namespace Surveyapi.Services
{
    public class EmployeeRepo : IRepo<int, Employee>
    {
        static List<Employee> _employees = new List<Employee>();
        public async Task<Employee> Add(Employee item)
        {
            _employees.Add(item);
            return item;
        }

        public async Task<ICollection<Employee>> GetAll()
        {
            return _employees;
        }
    }
}
