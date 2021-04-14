using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Owlbear.Dto.Creator;
using Owlbear.Model;
using Owlbear.Repository;
using Owlbear.Repository.Remote;

namespace Owlbear.Service
{
    public class CreatorService : ICreatorService
    {
        private readonly ICreatorRepository _creatorRepository;
        private readonly IRemoteTwitterRepository _remoteTwitterRepository;
        private readonly OwlbearContext _context;

        public CreatorService(ICreatorRepository creatorRepository, IRemoteTwitterRepository remoteTwitterRepository, OwlbearContext context)
        {
            _creatorRepository = creatorRepository;
            _remoteTwitterRepository = remoteTwitterRepository;
            _context = context;
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
            // Check if twitter already exists? twitter should be unique?
            if (creator.TwitterHandle != null)
            {
                var twitter = await _remoteTwitterRepository.GetTwitter(creator.TwitterHandle);
                entity.Twitter = twitter;
            }
            return await _creatorRepository.AddAsync(entity);
            /*

            await using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var creatorTask = _creatorRepository.AddAsync(entity);
                var twitterTask = _twitterRepository.AddAsync(entity.Twitter);
                Task.WaitAll(creatorTask, twitterTask);
                await transaction.CommitAsync();
                return await creatorTask;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw;
            }*/
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