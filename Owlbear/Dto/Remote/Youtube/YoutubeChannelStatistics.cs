using System.Diagnostics.CodeAnalysis;

namespace Owlbear.Dto.Remote.Youtube
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class YoutubeChannelStatistics
    {
        public long viewCount { get; set; }
        public long subscriberCount { get; set; }
    }
}