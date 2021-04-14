﻿using Owlbear.Model;

namespace Owlbear.Dto.Creator
{
    public class CreatorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Twitter Twitter { get; set; }
        public Twitch Twitch { get; set; }
        public Youtube Youtube { get; set; }
    }
}