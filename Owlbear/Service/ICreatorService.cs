using System.Collections.Generic;
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
        Task<Creator> UpdateCreatorAsync(UpdateCreatorDto creator);
        Task<Creator> DeleteCreatorAsync(int id);
    }
}