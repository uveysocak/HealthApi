namespace Health_Api.DataAccess.Abstracts;

public interface IGenericRepository<T> where T : class
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    List<T> GetAll();
    T GetById(int id);
    IQueryable<T> GetQueryable();
}
