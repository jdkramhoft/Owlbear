// ReSharper disable InconsistentNaming
namespace Owlbear.Dto.Remote.Twitter
{
    public class TweetPublicMetricsDto
    {
        public int retweet_count { get; set; }
        public int reply_count { get; set; }
        public int like_count { get; set; }
        public int quote_count { get; set; }
    }
}