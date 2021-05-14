using AutoMapper;
using Owlbear.Dto.Milestone;
using Owlbear.Model;

namespace Owlbear.Mapping
{
    public class MilestoneProfile : Profile
    {
        public MilestoneProfile()
        {
            CreateMap<Tweet, MilestoneTweetDto>();
            CreateMap<Milestone, MilestoneDto>();
        }
    }
}