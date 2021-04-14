using Microsoft.EntityFrameworkCore;
using Owlbear.Model;

namespace Owlbear.Repository
{
    public class CreatorRepository : BaseRepository<Creator>, ICreatorRepository
    {
        public CreatorRepository(OwlbearContext context) : base(context)
        {
        }
    }
}