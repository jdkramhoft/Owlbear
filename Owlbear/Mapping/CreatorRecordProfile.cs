using System;
using AutoMapper;
using Owlbear.Dto.Creator;
using Owlbear.Model;

namespace Owlbear.Mapping
{
    public class CreatorRecordProfile : Profile
    {
        public CreatorRecordProfile()
        {
            CreateMap<CreatorRecord, CreatorRecordDto>();
        }
    }
}