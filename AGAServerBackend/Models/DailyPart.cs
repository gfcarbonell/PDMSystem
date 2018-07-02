using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AGAServerBackend.Models
{
    public class DailyPart
    {
        [Key]
        [Required]
        //[Index(IsUnique = true)]
        //[Column("IdParte", Order = 0)]
        public int Id { get; set; }

        [Required]
        [StringLength(3)]
        //[Column("IdSucursal", Order = 1)]
        public string HeadquartersId { get; set; }

        [Required]
        [StringLength(12)]
        //[Column("IdMaquinaria", Order = 2)]
        public string MachineryId { get; set; }

        [Required]
        [StringLength(2)]
        //[ForeignKey("ImplementType")]
        //[Column("IdTipoImplemento", Order = 3)]
        public string ImplementTypeId { get; set; }

        [Required]
        [StringLength(12)]
        //[Column("IdImplemento", Order = 4)]
        public string ImplementId { get; set; }

        [Required]
        [StringLength(6)]
        //[Column("IdOperario", Order = 5)]
        public string OperatorId { get; set; }

        [Required]
        [StringLength(2)]
        //[Column("IdTurn", Order = 6)]
        public string TurnId { get; set; }

        //[ForeignKey("Status")]
        //[Column("IdEstado", Order = 7)]
        public int StatudId { get; set; }


        [Display(Name = "Situación")]
        //[Column("Situacion", Order = 8)]
        public int Situation { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        //[Column("Fecha", Order = 9)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de creación")]
        //[Column("FechaCreacion", Order = 10)]
        public DateTime CreationDate { get; set; }

        [Required]
        [Display(Name = "Usuario creación")]
        [StringLength(100)]
        //[Column("UsuarioCreacion", Order = 11)]
        public string UserCreation { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de modificación")]
        //[Column("FechaCreacion", Order = 12)]
        public DateTime ModificationDate { get; set; }

        [Required]
        [Display(Name = "Usuario de modificación")]
        [Column("UsuarioModificacion", Order = 13)]
        [StringLength(100)]
        public string UserModification { get; set; }

        //public ImplementType ImplementType { get; set; }

        //public Status Status { get; set; }
    }
}