using System.Diagnostics.CodeAnalysis;

namespace Owlbear.Dto.Remote.Youtube
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class YoutubeChannelItems
    {
        public YoutubeChannelStatistics statistics { get; set; }
    }
}