using Contracts;
using Microsoft.EntityFrameworkCore;
using Repository.Specification;
using System.Linq.Expressions;

namespace Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _db;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();

        }

        public IQueryable<T> GetAll(bool trackChanges) =>
            !trackChanges ?
            _db.AsNoTracking() :
            _db;


        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
            _db.AsNoTracking()
            .Where(expression):
            _db.Where(expression);
        


        public void Create(T entity)
        {
            _db.Add(entity);
        }

        public void Delete(T entity)
        {
            _db.Remove(entity);
        }

        

        public void Update(T entity)
        {
            _db.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            
        }

      
    }
}
