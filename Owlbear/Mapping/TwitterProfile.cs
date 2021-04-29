using System.Collections.Generic;
using AutoMapper;
using Owlbear.Dto.Remote.Twitter;
using Owlbear.Model;

namespace Owlbear.Mapping
{
    public class TwitterProfile : Profile
    {
        public TwitterProfile()
        {
            CreateMap<RemoteTwitterResponseDto, Twitter>()
                .ForMember(twitter => twitter.RemoteId,
                    opt => opt.MapFrom(src => src.data.id))
                .ForMember(twitter => twitter.Handle,
                    opt => opt.MapFrom(src => src.data.username))
                .ForMember(twitter => twitter.ImageUrl,
                    opt => opt.MapFrom(src => src.data.profile_image_url))
                .ForMember(twitter => twitter.Followers,
                    opt => opt.MapFrom(src => src.data.public_metrics.followers_count))
                .ForMember(twitter => twitter.Description,
                    opt => opt.MapFrom(src => src.data.description));
            CreateMap<Data, Tweet>()
                .ForMember(tweet => tweet.Text,
                    opt => opt.MapFrom(src => src.text))
                .ForMember(tweet => tweet.RemoteId,
                    opt => opt.MapFrom(src => src.id))
                .ForMember(tweet => tweet.Likes,
                    opt => opt.MapFrom(src => src.public_metrics.like_count))
                .ForMember(tweet => tweet.Replies,
                    opt => opt.MapFrom(src => src.public_metrics.reply_count))
                .ForMember(tweet => tweet.Quotes,
                    opt => opt.MapFrom(src => src.public_metrics.quote_count))
                .ForMember(tweet => tweet.Retweets,
                    opt => opt.MapFrom(src => src.public_metrics.retweet_count));
        }
    }
}