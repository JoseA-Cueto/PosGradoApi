using Microsoft.EntityFrameworkCore;
using PosgradoAPI.DataBaseContext;
using System.Linq.Expressions;

namespace PosgradoAPI.DataLayer.RepoBase
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return await _context.Set<T>().CountAsync(); 
            }

            return await _context.Set<T>().CountAsync(predicate); 
        }


    }

}
