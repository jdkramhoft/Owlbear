using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owlbear.Model
{
    public class Milestone
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MilestoneId { get; set; }
        [Required]
        public Tweet Tweet { get; set; }
    }
}