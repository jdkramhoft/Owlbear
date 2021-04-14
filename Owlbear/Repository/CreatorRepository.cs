using Microsoft.EntityFrameworkCore;
using Owlbear.Model;

namespace Owlbear.Repository
{
    public class CreatorRepository : BaseRepository<Creator>, ICreatorRepository
    {
        public CreatorRepository(DbContext context) : base(context)
        {
        }
    }
}