namespace Surveyapi.Services
{
    public interface IRepo<K,T>
    {
        Task<T> Add(T item);
        Task<ICollection<T>> GetAll();
    }
}
