using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGAServerBackend.Models
{
    public class Turn
    {
        [Key]
        [Required]
        [StringLength(2)]
        [Index(IsUnique = true)]
        public int TurnId { get; set; }

        [Required]
        [StringLength(20)]
        [Index(IsUnique = true)]
        public string Description { get; set; }
    }
}