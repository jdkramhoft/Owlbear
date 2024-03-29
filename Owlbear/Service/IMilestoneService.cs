﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Owlbear.Model;

namespace Owlbear.Service
{
    public interface IMilestoneService
    {
        Task TweetMilestones(Creator creator, Creator updated);
        Task<List<Milestone>> GetAllMilestonesAsync();
    }
}