using System.Linq.Expressions;

namespace FLEXCrm.Interfaces.BaseEntity
{
    public interface IBaseInterface<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> FindByIdAsync(int id);
        Task<TEntity> GetInsertedObjByAsync(TEntity entity);
        Task<bool> InsertByAsync(TEntity entity);
        Task<bool> InsertRangeByAsync(IEnumerable<TEntity> entities);
        Task<bool> Update(TEntity entity);
        Task<bool> UpdateRangeByAsync(IEnumerable<TEntity> entities);
        Task<bool> Delete(TEntity entity);
        Task<bool> DeleteRange(IEnumerable<TEntity> entities);
    }
}
