using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Owlbear.Model;
using Owlbear.Repository.Base;

namespace Owlbear.Repository
{
    public class CreatorRepository : BaseRepository<Creator>, ICreatorRepository
    {
        
        public CreatorRepository(OwlbearContext context) : base(context)
        {
        }
        
        public new IQueryable<Creator> GetAll()
        {
            try
            {
                return Context.Set<Creator>()
                    .Include(creator => creator.Twitter)
                    .Include(creator => creator.Twitch)
                    .Include(creator => creator.Youtube);
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public new async Task<Creator> GetAsync(int id)
        {
            try
            {
                var entity = await Context.Creators
                    .Include(creator => creator.Twitter)
                    .Include(creator => creator.Twitch)
                    .Include(creator => creator.Youtube)
                    .FirstAsync(creator => creator.CreatorId == id);
                if (entity == null) throw new RepositoryException($"Couldn't find entity with id: {id}");
                return entity;
            }
            catch (Exception ex) when (ex is not RepositoryException)
            {
                throw new RepositoryException($"Couldn't retrieve entity: {ex.Message}");
            }
        }
    }
}