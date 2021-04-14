using AutoMapper;
using Owlbear.Dto.Creator;
using Owlbear.Model;

namespace Owlbear.Mapping
{
    public class CreatorProfile : Profile
    {
        public CreatorProfile()
        {
            CreateMap<Creator, CreatorDto>();
        }
    }
}