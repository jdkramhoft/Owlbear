using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Owlbear.Model
{
    public class Twitch
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TwitterId { get; set; }
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
    }
}