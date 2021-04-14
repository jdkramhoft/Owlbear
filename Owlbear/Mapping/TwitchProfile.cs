using AutoMapper;
using Owlbear.Dto.Remote.Twitch;
using Owlbear.Model;

namespace Owlbear.Mapping
{
    public class TwitchProfile : Profile
    {
        public TwitchProfile()
        {
            CreateMap<RemoteTwitchFollowersResponseDto, Twitch>()
                .ForMember(twitch => twitch.Followers, 
                    opt => opt.MapFrom(src => src.total));
            
            CreateMap<RemoteTwitchUserResponseDto, Twitch>()
                .ForMember(twitch => twitch.Description, 
                    opt => opt.MapFrom(src => src.data[0].description))
                .ForMember(twitch => twitch.RemoteLogin, 
                opt => opt.MapFrom(src => src.data[0].login))
                .ForMember(twitch => twitch.Handle, 
                    opt => opt.MapFrom(src => src.data[0].display_name))
                .ForMember(twitch => twitch.Views, 
                    opt => opt.MapFrom(src => src.data[0].view_count))
                .ForMember(twitch => twitch.RemoteId, 
                    opt => opt.MapFrom(src => src.data[0].id))
                .ForMember(twitch => twitch.OfflineImageUrl, 
                    opt => opt.MapFrom(src => src.data[0].offline_image_url))
                .ForMember(twitch => twitch.ProfileImageUrl, 
                    opt => opt.MapFrom(src => src.data[0].profile_image_url));
        }
    }
}