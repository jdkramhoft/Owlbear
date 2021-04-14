using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Owlbear.Model;
using Owlbear.Repository;

namespace Owlbear.Service
{
    public class CreatorService : ICreatorService
    {
        private readonly ICreatorRepository _creatorRepository;

        public CreatorService(ICreatorRepository creatorRepository)
        {
            _creatorRepository = creatorRepository;
        }

        public async Task<List<Creator>> GetAllCreatorsAsync()
        {
            return await _creatorRepository.GetAll().ToListAsync();
        }

        public async Task<Creator> GetCreatorAsync(string id)
        {
            return await _creatorRepository.GetAsync(id);
        }

        public async Task<Creator> AddCreatorAsync(Creator creator)
        {
            return await _creatorRepository.AddAsync(creator);
        }

        public async Task<Creator> UpdateCreatorAsync(Creator creator)
        {
            return await _creatorRepository.UpdateAsync(creator);
        }

        public async Task<Creator> DeleteCreatorAsync(string id)
        {
            return await _creatorRepository.DeleteAsync(id);
        }
    }
}