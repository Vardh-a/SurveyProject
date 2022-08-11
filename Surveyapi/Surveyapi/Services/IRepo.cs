namespace Surveyapi.Services
{
    public interface IRepo<T>
    {
        Task<T> Add(T item);
        IEnumerable<T> GetAll();
        
    }
}
