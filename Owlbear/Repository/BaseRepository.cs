using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Owlbear.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        private readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _context.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<TEntity> GetAsync(string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            try
            {
                var entity = await _context.FindAsync<TEntity>(id);
                if (entity == null) throw new RepositoryException($"Couldn't find entity with id: {id}");
                return entity;
            }
            catch (Exception ex)
            {
                if (ex is RepositoryException) throw;
                throw new RepositoryException($"Couldn't retrieve entity: {ex.Message}");
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            try
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Couldn't add entity: {ex.Message}");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            try
            {
                _context.Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Couldn't update entity: {ex.Message}");
            }
        }

        public async Task<TEntity> DeleteAsync(string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            try
            {
                var entity = await GetAsync(id);
                _context.Remove(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Couldn't delete entity: {ex.Message}");
            }
        }
    }
}