using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Owlbear.Dto.Creator;

namespace Owlbear.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class CreatorController : ControllerBase
    {

        private readonly ILogger<CreatorController> _logger;

        public CreatorController(ILogger<CreatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public CreatorDto Get()
        {
            var creator = new CreatorDto {Name = "TestName"};
            return creator;
        }

        [HttpPost]
        public CreatorDto Post(CreateCreatorDto dto)
        {
            return new CreatorDto() {Name = dto.Name, Id = dto.Id};
        }
    }
}