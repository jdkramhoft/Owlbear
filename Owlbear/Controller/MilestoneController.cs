using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Owlbear.Dto.Milestone;
using Owlbear.Model;
using Owlbear.Service;

namespace Owlbear.Controller
{
    [ApiController]
    [Route("api/milestones")]
    public class MilestoneController
    {
        private readonly ILogger<CreatorController> _logger;
        private readonly IMapper _mapper;
        private readonly IMilestoneService _milestoneService;

        public MilestoneController(ILogger<CreatorController> logger, IMapper mapper, IMilestoneService milestoneService)
        {
            _logger = logger;
            _mapper = mapper;
            _milestoneService = milestoneService;
        }
        
        [HttpGet("tweets")]
        public async Task<List<MilestoneDto>> GetAll()
        {
            return _mapper.Map<List<MilestoneDto>>(await _milestoneService.GetAllMilestonesAsync());
        }
    }
}