﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Maqeem.Models
{
    public class Property
    {
        public uint PropertyID { get; set; }

        [Required(ErrorMessage="Please enter Location of the property"),MaxLength(100)]
        public string Location { get; set; }

        [MaxLength(50)]
        public string? GoogleMapsLink { get; set; }
        
        [Required(ErrorMessage="Please enter Image of the Property"),MaxLength(50)]        
        public string ImageLink { get; set; }
        [Required]
        public uint Area { get; set; }
        [Required]
        public uint Price { get; set; }
        [Required]
        public uint BedsNum { get; set; }
        [Required]
        public uint RoomsNum { get; set; }
        [Required]
        public uint PathsNum { get; set; }

        public Deal Deal { get; set; }
        public IEnumerable<CategoryGroup> CategoryGroups { get; set; }
        public Country Country { get; set; }
    }
}

