using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGAServerBackend.Models
{
    [Table("PDM_TIPO_EMPLEADO")]
    public class ImplementType
    {
        [Key]
        [Required]
        [StringLength(2)]
        [Index(IsUnique = true)]
        [Column("IdTipoImplemento", Order = 0)]
        public string Id { get; set; }

        [Required]
        [StringLength(30)]
        [Index(IsUnique = true)]
        [Column("Descripcion", Order = 1)]
        public string Description { get; set; }

        public ICollection<DailyPart> DailyParts { get; set; }
    }
}