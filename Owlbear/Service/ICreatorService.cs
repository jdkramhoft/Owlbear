using System.Collections.Generic;
using System.Threading.Tasks;
using Owlbear.Model;

namespace Owlbear.Service
{
    public interface ICreatorService
    {
        Task<List<Creator>> GetAllCreatorsAsync();
        Task<Creator> GetCreatorAsync(string id);
        Task<Creator> AddCreatorAsync(Creator creator);
        Task<Creator> UpdateCreatorAsync(Creator creator);
        Task<Creator> DeleteCreatorAsync(string id);
    }
}