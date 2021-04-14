using System.Diagnostics.CodeAnalysis;

namespace Owlbear.Dto.Remote.Twitter
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class RemoteTwitterDto
    {
        public string profile_image_url { get; set; }
        public PublicMetricsDto public_metrics { get; set; } //TODO: Add not null annotation, and others to classes in directory
        public string description { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }
}