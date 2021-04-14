using System.Diagnostics.CodeAnalysis;

namespace Owlbear.Dto.Remote.Twitter
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class RemoteTwitterResponseDto
    {
        public RemoteTwitterDto data { get; set; }
    }
}