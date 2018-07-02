using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGAServerBackend.Models
{
    public class Headquarters
    {
        [Key]
        [Required]
        [StringLength(3)]
        [Index(IsUnique = true)]
        public string Id { get; set; }

        [Required]
        [StringLength(30)]
        [Index(IsUnique = true)]
        public string Description { get; set; }
    }
}