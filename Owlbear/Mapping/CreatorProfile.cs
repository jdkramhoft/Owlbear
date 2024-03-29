﻿using System;
using AutoMapper;
using Owlbear.Dto.Creator;
using Owlbear.Model;

namespace Owlbear.Mapping
{
    public class CreatorProfile : Profile
    {
        public CreatorProfile()
        {
            CreateMap<Creator, CreatorDto>()
                .ForMember(dto => dto.Id,
                opt => opt.MapFrom(src => src.CreatorId));
            CreateMap<Creator, CreatorRecord>()
                .ForMember(creator => creator.Date,
                    opt => opt.MapFrom(src => DateTime.Now));
        }
    }
}