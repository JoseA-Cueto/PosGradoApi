using System.Linq.Expressions;

namespace PosgradoAPI.DataLayer.RepoBase
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> FindByIdAsync(int id);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null); 

    }

}
