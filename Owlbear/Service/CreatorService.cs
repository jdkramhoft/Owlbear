using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Owlbear.Dto.Creator;
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

        public async Task<Creator> GetCreatorAsync(int id)
        {
            return await _creatorRepository.GetAsync(id);
        }

        public async Task<Creator> AddCreatorAsync(CreateCreatorDto creator)
        {
            var entity = new Creator {Name = creator.Name};
            return await _creatorRepository.AddAsync(entity);
        }

        public async Task<Creator> UpdateCreatorAsync(int id, UpdateCreatorDto creator)
        {
            var entity = await _creatorRepository.GetAsync(id);
            entity.Name = creator.Name;
            return await _creatorRepository.UpdateAsync(entity);
        }

        public async Task<Creator> DeleteCreatorAsync(int id)
        {
            return await _creatorRepository.DeleteAsync(id);
        }
    }
}