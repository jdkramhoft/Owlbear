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
        }
    }
}