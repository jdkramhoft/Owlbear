using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owlbear.Model
{
    public class Tweet
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TweetId { get; set; }
        [Required]
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