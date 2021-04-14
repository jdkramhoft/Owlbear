using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Owlbear.Dto.Creator;
using Owlbear.Model;
using Owlbear.Service;

namespace Owlbear.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class CreatorController : ControllerBase
    {

        private readonly ILogger<CreatorController> _logger;
        private readonly IMapper _mapper;
        private readonly ICreatorService _creatorService;

        public CreatorController(ILogger<CreatorController> logger, IMapper mapper, ICreatorService creatorService)
        {
            _logger = logger;
            _mapper = mapper;
            _creatorService = creatorService;
        }

        [HttpGet]
        public async Task<CreatorDto> Get(int id)
        {
            return _mapper.Map<CreatorDto>(await _creatorService.GetCreatorAsync(id));
        }

        [HttpPost]
        public async Task<CreatorDto> Post(CreateCreatorDto dto)
        {
            return _mapper.Map<CreatorDto>(await _creatorService.AddCreatorAsync(dto));
        }
    }
}