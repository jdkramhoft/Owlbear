using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owlbear.Model
{
    public class Twitch
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TwitchId { get; set; }
        [Required]
        public int RemoteId { get; set; }
        [Required]
        public string RemoteLogin { get; set; }
        [Required]
        public string Handle { get; set; }
        [Range(0, int.MaxValue)]
        public int Followers { get; set; }
        [Range(0, long.MaxValue)]
        public long Views { get; set; }
        public string Description { get; set; }
        public string ProfileImageUrl { get; set; }
        public string OfflineImageUrl { get; set; }

        public Twitch Copy()
        {
            return new Twitch()
            {
                TwitchId = TwitchId, RemoteId = RemoteId, RemoteLogin = RemoteLogin, Description = Description,
                Followers = Followers, Handle = Handle, Views = Views, OfflineImageUrl = OfflineImageUrl,
                ProfileImageUrl = ProfileImageUrl
            };
        }
    }
}