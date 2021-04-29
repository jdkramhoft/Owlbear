using System.Diagnostics.CodeAnalysis;

namespace Owlbear.Dto.Remote.Twitter
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class UserPublicMetricsDto
    {
        public int followers_count { get; set; }
        public int following_count { get; set; }
        public int tweet_count { get; set; }
        public int listed_count { get; set; }
    }
}