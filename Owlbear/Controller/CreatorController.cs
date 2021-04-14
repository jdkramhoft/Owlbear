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
    [Route("api/creators")]
    public class CreatorController : ControllerBase
    {

        private readonly ILogger<CreatorController> _logger;
        private readonly IMapper _mapper;
        private readonly ICreatorService _creatorService;

        public CreatorController(ILogger<CreatorController> logger,OwlbearContext context, IMapper mapper, ICreatorService creatorService)
        {
            _logger = logger;
            _mapper = mapper;
            _creatorService = creatorService;
        }

        [HttpGet("{id}")]
        public async Task<CreatorDto> Get(int id)
        {
            return _mapper.Map<CreatorDto>(await _creatorService.GetCreatorAsync(id));
        }
        
        [HttpGet]
        public async Task<List<CreatorDto>> GetAll()
        {
            
            return _mapper.Map<List<CreatorDto>>(await _creatorService.GetAllCreatorsAsync());
        }

        [HttpPost]
        public async Task<CreatorDto> Post(CreateCreatorDto dto)
        {
            return _mapper.Map<CreatorDto>(await _creatorService.AddCreatorAsync(dto));
        }
        
        [HttpPut("{id}")]
        public async Task<CreatorDto> Update(int id, UpdateCreatorDto dto)
        {
            return _mapper.Map<CreatorDto>(await _creatorService.UpdateCreatorAsync(id, dto));
        }
        
        [HttpDelete("{id}")]
        public async Task<CreatorDto> Delete(int id)
        {
            return _mapper.Map<CreatorDto>(await _creatorService.DeleteCreatorAsync(id));
        }
    }
}