﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetTrakr.Models
{
    [PrimaryKey(nameof(PlatformId))]
    public class Platform : Base
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlatformId { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public required string Name { get; set; }
        
        public string? Notes { get; set; }

        [DisplayName("Archived")]
        public bool IsArchived { get; set; } = false;

        public int ManufacturerId { get; set; }

        [ForeignKey("ManufacturerId")] // Define ForeignKey attribute to represent the relationship
        public required Manufacturer Manufacturer { get; set; } // Direct navigation property to Manufacturer entity

    }
}
