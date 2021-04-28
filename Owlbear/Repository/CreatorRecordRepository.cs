using System.Linq;
using System.Threading.Tasks;
using Owlbear.Model;
using Owlbear.Repository.Base;

namespace Owlbear.Repository
{
    public class CreatorRecordRepository : BaseRepository<CreatorRecord>, ICreatorRecordRepository
    {
        public CreatorRecordRepository(OwlbearContext context) : base(context)
        {
        }
    }
}