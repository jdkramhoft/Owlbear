using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Owlbear.Dto.Remote.Twitch
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class RemoteTwitchUserResponseDto
    {
        public List<RemoteTwitchDto> data;
    }
}