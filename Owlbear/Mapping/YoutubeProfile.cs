using AutoMapper;
using Owlbear.Dto.Remote.Youtube;
using Owlbear.Model;

namespace Owlbear.Mapping
{
    public class YoutubeProfile : Profile
    {
        public YoutubeProfile()
        {
            CreateMap<RemoteYoutubeResponseDto, Youtube>()
                .ForMember(youtube => youtube.Subscribers,
                    opt => opt.MapFrom(src => src.items[0].statistics.subscriberCount))
                .ForMember(youtube => youtube.TotalViews,
                    opt => opt.MapFrom(src => src.items[0].statistics.viewCount))
                .ForMember(youtube => youtube.RemoteId,
                    opt => opt.MapFrom(src => src.items[0].id));
        }
    }
}