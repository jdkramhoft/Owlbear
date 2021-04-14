using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owlbear.Model
{
    public class Creator
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CreatorId { get; set; }
        [Required]
        public string Name { get; set; }
        public Twitter Twitter { get; set; }
    }
}