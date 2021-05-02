using System.Collections.Generic;
using System.Threading.Tasks;
using Owlbear.Model;

namespace Owlbear.Service
{
    public interface ICreatorRecordService
    {
        Task<List<CreatorRecord>> GetCreatorHistoryAsync(int id);
    }
}