﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }        

        [Required]
        [ForeignKey(nameof(Post))]
        public int PostId { get; set; }


        [Required]
        public Guid Author { get; set; }


        [Required]
        public string Text { get; set; }


        public virtual Post Post { get; set; }                     
        

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
