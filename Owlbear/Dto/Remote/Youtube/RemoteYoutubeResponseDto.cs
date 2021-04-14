using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Owlbear.Dto.Remote.Youtube
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class RemoteYoutubeResponseDto
    {
        public List<YoutubeChannelItems> items { get; set; }
    }
}