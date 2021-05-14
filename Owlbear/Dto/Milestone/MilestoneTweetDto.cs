using System.ComponentModel.DataAnnotations;

namespace Owlbear.Dto.Milestone
{
    public class MilestoneTweetDto
    {
        public string RemoteId { get; set; }
        [Required]
        public string Text { get; set; }
        [Range(0, int.MaxValue)]
        public int Likes { get; set; }
        [Range(0, int.MaxValue)]
        public int Retweets { get; set; }
        [Range(0, int.MaxValue)]
        public int Quotes { get; set; }
        [Range(0, int.MaxValue)]
        public int Replies { get; set; }
    }
}