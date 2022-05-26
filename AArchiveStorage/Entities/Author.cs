﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveStorage.Entities
{
    public class Author
    {
        [Key]
        public int  Id { get; set; }


        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 chars")]
        public string Name { get; set; }


        [Display(Name = "Born")]
        [Required(ErrorMessage = "Born is required.")]
        public int Born { get; set; }


        [Display(Name = "Death")]
        public int? Death { get; set; }


        [Display(Name = "About")]
        public string? About { get; set; }

    }
}
