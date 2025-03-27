using Health_Api.DataAccess.Abstracts;
using Health_Api.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace Health_Api.DataAccess.Concretes;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private BaseDbContext _ctx;
    private DbSet<T> _dbSet;

    public GenericRepository(BaseDbContext context)
    {
        _ctx = context;
        _dbSet = _ctx.Set<T>();
    }
    public void Add(T entity)
    {
        _dbSet.Add(entity);
        _ctx.SaveChanges();
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
        _ctx.SaveChanges();
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
        _ctx.SaveChanges();
    }

    public List<T> GetAll()
    {
        List<T> list = _dbSet.ToList();
        return list;
    }

    public T GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public IQueryable<T> GetQueryable()
    {
        throw new NotImplementedException();
    }
}
