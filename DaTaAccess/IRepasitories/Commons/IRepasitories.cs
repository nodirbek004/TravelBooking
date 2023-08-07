using Domain.Commons.AudiTable;

namespace DaTaAccess.IRepasitories.Commons;

public interface IRepasitories<T> where T : AudiTable
{
    Task<T> CreateAsync(T entity);
    T Update(T entity);
    Task<T> GetByIdAsync(long id);
    void Delete(T entity);
    IQueryable<T> GetAll();
    Task<int> SaveAsync();

}
