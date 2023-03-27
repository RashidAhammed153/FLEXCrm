using FLEXCrm.Data;
using FLEXCrm.Interfaces.BaseEntity;
using Microsoft.EntityFrameworkCore;

namespace FLEXCrm.Repositories.BaseRepository
{
    public class BaseRepository<TEntity>:IBaseInterface<TEntity> where TEntity : class
    {

        protected readonly FLEXBDContext _flexbdContext;

        public BaseRepository(FLEXBDContext flexbdContext)
        {
            _flexbdContext = flexbdContext;
        }


        public async Task<bool> Delete(TEntity entity)
        {
            try
            {
                _flexbdContext.Set<TEntity>().Remove(entity);
                await SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> DeleteRange(IEnumerable<TEntity> entities)
        {
            try
            {
                _flexbdContext.Set<TEntity>().RemoveRange(entities);
                await SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<TEntity> FindByIdAsync(int id)
        {
            try
            {
                _flexbdContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                var res = await _flexbdContext.Set<TEntity>().FindAsync(id);
                return res;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            try
            {
                return await _flexbdContext.Set<TEntity>().ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<TEntity> GetInsertedObjByAsync(TEntity entity)
        {
            try
            {
                await _flexbdContext.Set<TEntity>().AddAsync(entity);
                await SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }
        }

        public async Task<bool> InsertByAsync(TEntity entity)
        {
            try
            {
                await _flexbdContext.Set<TEntity>().AddAsync(entity);
                await SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        public async Task<bool> InsertRangeByAsync(IEnumerable<TEntity> entities)
        {
            try
            {
                await _flexbdContext.Set<TEntity>().AddRangeAsync(entities);
                await SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        public async Task<bool> Update(TEntity entity)
        {
            try
            {
                var result = _flexbdContext.Set<TEntity>().Attach(entity);
                result.State = EntityState.Modified;
                await SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        public async Task<bool> UpdateTr(TEntity entity)
        {
            try
            {
                var result = _flexbdContext.Set<TEntity>().Update(entity);
                result.State = EntityState.Modified;
                await SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }

        public async Task<bool> UpdateRangeByAsync(IEnumerable<TEntity> entities)
        {
            try
            {
                _flexbdContext.Set<TEntity>().UpdateRange(entities);
                await SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await _flexbdContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _flexbdContext.Dispose();
        }

    }
}
