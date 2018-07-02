using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGAServerBackend.Models
{
    public class Machinery
    {
        [Key]
        [Required]
        [StringLength(12)]
        [Index(IsUnique = true)]
        public string Id { get; set; }
    }
}