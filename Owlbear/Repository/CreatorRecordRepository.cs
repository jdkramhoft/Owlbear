using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Owlbear.Model;
using Owlbear.Repository.Base;

namespace Owlbear.Repository
{
    public class CreatorRecordRepository : BaseRepository<CreatorRecord>, ICreatorRecordRepository
    {
        public CreatorRecordRepository(OwlbearContext context) : base(context)
        {
        }

        public new IQueryable<CreatorRecord> GetAll()
        {
            try
            {
                return Context.Set<CreatorRecord>()
                    .Include(record => record.Twitter.Tweets)
                    .Include(record => record.Twitch)
                    .Include(record => record.Youtube);
            }
            catch (Exception ex)
            {
                throw new RepositoryException($"Couldn't retrieve entities: {ex.Message}");
            }
        }
    }
}