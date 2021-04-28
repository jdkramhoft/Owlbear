using System;
using AutoMapper;
using Owlbear.Model;

namespace Owlbear.Mapping
{
    public class CreatorRecordProfile : Profile
    {
        public CreatorRecordProfile()
        {
            CreateMap<Creator, CreatorRecord>()
                .ForMember(creator => creator.Date,
                    opt => opt.MapFrom(src => DateTime.Now));
        }
    }
}