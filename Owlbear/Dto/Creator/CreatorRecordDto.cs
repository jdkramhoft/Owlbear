using System;
using Owlbear.Model;

namespace Owlbear.Dto.Creator
{
    public class CreatorRecordDto
    {
        public int CreatorId { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public Twitter Twitter { get; set; }
        public Twitch Twitch { get; set; }
        public Youtube Youtube { get; set; }
    }
}