using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Owlbear.Dto.Creator;
using Owlbear.Model;

namespace Owlbear.Service
{
    public interface ICreatorService
    {
        Task<List<Creator>> GetAllCreatorsAsync();
        Task<Creator> GetCreatorAsync(int id);
        Task<Creator> AddCreatorAsync(CreateCreatorDto creator);
        Task<Creator> UpdateCreatorAsync(int id, UpdateCreatorDto creator);
        Task<Creator> DeleteCreatorAsync(int id);
        Task<Creator> RefreshCreatorAsync(int id);
    }
}