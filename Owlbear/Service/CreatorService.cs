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
        private readonly IRemoteTwitchRepository _remoteTwitchRepository;
        private readonly IRemoteYoutubeRepository _remoteYoutubeRepository;

        public CreatorService(ICreatorRepository creatorRepository, IRemoteTwitterRepository remoteTwitterRepository,
            IRemoteTwitchRepository remoteTwitchRepository, IRemoteYoutubeRepository remoteYoutubeRepository)
        {
            _creatorRepository = creatorRepository;
            _remoteTwitterRepository = remoteTwitterRepository;
            _remoteTwitchRepository = remoteTwitchRepository;
            _remoteYoutubeRepository = remoteYoutubeRepository;
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
            // Check if twitter etc already exists? twitter etc should be unique?
            if (creator.TwitterHandle != null)
            {
                var twitter = await _remoteTwitterRepository.GetTwitter(creator.TwitterHandle);
                entity.Twitter = twitter;
            }
            if (creator.TwitchHandle != null)
            {
                var twitch = await _remoteTwitchRepository.GetTwitch(creator.TwitchHandle);
                entity.Twitch = twitch;
            }
            if (creator.YoutubeHandle != null)
            {
                var youtube = await _remoteYoutubeRepository.GetYoutube(creator.YoutubeHandle);
                entity.Youtube = youtube;
            }
            return await _creatorRepository.AddAsync(entity);
        }

        public async Task<Creator> UpdateCreatorAsync(int id, UpdateCreatorDto creator)
        {
            var entity = await _creatorRepository.GetAsync(id);
            entity.Name = creator.Name;
            if (creator.TwitterHandle != null)
            {
                var twitter = await _remoteTwitterRepository.GetTwitter(creator.TwitterHandle);
                entity.Twitter = twitter;
            }
            if (creator.TwitchHandle != null)
            {
                var twitch = await _remoteTwitchRepository.GetTwitch(creator.TwitchHandle);
                entity.Twitch = twitch;
            }
            if (creator.YoutubeHandle != null)
            {
                var youtube = await _remoteYoutubeRepository.GetYoutube(creator.YoutubeHandle);
                entity.Youtube = youtube;
            }
            return await _creatorRepository.UpdateAsync(entity);
        }

        public async Task<Creator> DeleteCreatorAsync(int id)
        {
            return await _creatorRepository.DeleteAsync(id);
        }

        public async Task<Creator> RefreshCreatorAsync(int id)
        {
            var creator = await _creatorRepository.GetAsync(id);
            if (creator.Twitter != null)
            {
                var handle = creator.Twitter.Handle;
                var twitter = await _remoteTwitterRepository.GetTwitter(handle);
                creator.Twitter = twitter;
            }
            if (creator.Twitch != null)
            {
                var handle = creator.Twitch.Handle;
                var twitch = await _remoteTwitchRepository.GetTwitch(handle);
                creator.Twitch = twitch;
            }
            if (creator.Youtube != null)
            {
                var channelId = creator.Youtube.RemoteId;
                var youtube = await _remoteYoutubeRepository.GetYoutube(channelId);
                creator.Youtube = youtube;
            }
            return await _creatorRepository.UpdateAsync(creator);
        }
    }
}