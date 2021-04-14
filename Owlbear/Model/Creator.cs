using System.ComponentModel.DataAnnotations;

namespace Owlbear.Model
{
    public class Creator
    {
        [Key]
        public int CreatorId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}