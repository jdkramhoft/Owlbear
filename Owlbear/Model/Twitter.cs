using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Owlbear.Model
{
    public class Twitter
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TwitterId { get; set; }
        [Required]
        public string RemoteId { get; set; }
        [Required]
        public string Handle { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Followers { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<Tweet> Tweets { get; set; }

        public Twitter Copy()
        {
            return new()
            {
                TwitterId = TwitterId, RemoteId = RemoteId, Description = Description, Followers = Followers,
                Handle = Handle, Tweets = new List<Tweet>(), ImageUrl = ImageUrl
            };
        }
    }
}