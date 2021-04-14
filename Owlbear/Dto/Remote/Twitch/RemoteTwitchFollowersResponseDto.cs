using System.Diagnostics.CodeAnalysis;

namespace Owlbear.Dto.Remote.Twitch
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class RemoteTwitchFollowersResponseDto
    {
        public int total { get; set; }
    }
}