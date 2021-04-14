using System;
using System.Linq;
using System.Threading.Tasks;
using Owlbear.Model;

namespace Owlbear.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        protected readonly OwlbearContext Context;

        public BaseRepository(OwlbearContext context)
        {
            Context = context;
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return Context.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<TEntity> GetAsync(int id)
        {
            try
            {
                var entity = await Context.FindAsync<TEntity>(id);
                if (entity == null) throw new RepositoryException($"Couldn't find entity with id: {id}");
                return entity;
            }
            catch (Exception ex) when (ex is not RepositoryException)
            {
                throw new RepositoryException($"Couldn't retrieve entity: {ex.Message}");
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            try
            {
                await Context.AddAsync(entity);
                await Context.SaveChangesAsync();
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
                Context.Update(entity);
                await Context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Couldn't update entity: {ex.Message}");
            }
        }

        public async Task<TEntity> DeleteAsync(int id)
        {
            try
            {
                var entity = await GetAsync(id);
                Context.Remove(entity);
                await Context.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Couldn't delete entity: {ex.Message}");
            }
        }
    }
}