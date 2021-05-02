using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owlbear.Model
{
    public class CreatorRecord
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CreatorRecordId { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int CreatorId { get; set; }
        [Column(TypeName = "date")] 
        [Required] 
        public DateTime Date { get; set; }
        [Required]
        public string Name { get; set; }
        public Twitter Twitter { get; set; }
        public Twitch Twitch { get; set; }
        public Youtube Youtube { get; set; }
    }
}