using System.Diagnostics.CodeAnalysis;

namespace Owlbear.Dto.Remote.Twitch
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class RemoteTwitchDto
    {
        public string id { get; set; }
        public string login { get; set; }
        public string display_name { get; set; }
        public string description { get; set; }
        public string profile_image_url { get; set; }
        public string offline_image_url { get; set; }
        public long view_count { get; set; }
    }
}