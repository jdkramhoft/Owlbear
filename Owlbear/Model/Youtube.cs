using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owlbear.Model
{
    public class Youtube
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YoutubeId { get; set; }
        [Required]
        public string RemoteId { get; set; }
        [Range(0, long.MaxValue)]
        public long TotalViews { get; set; }
        [Range(0, long.MaxValue)]
        public long Subscribers { get; set; }
    }
}