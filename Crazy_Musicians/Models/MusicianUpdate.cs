﻿using System.ComponentModel.DataAnnotations;

namespace Crazy_Musicians.Models
{
    public class MusicianUpdate
    {
        [Required, MinLength(5), MaxLength(50)]
        public string FullName { get; set; }

        [MinLength(5), MaxLength(100)]
        public string? Skill { get; set; }

        [MinLength(5), MaxLength(100)]
        public string? FunFeature { get; set; }

    }
}
