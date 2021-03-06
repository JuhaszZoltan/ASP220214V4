using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP220214V4.Models
{
    [Table("Ugyfelek")]
    public class Ugyfel
    {
        [Key, Required]
        public int Id { get; set; }
        [Display(Name = "Név:")]
        [Required(ErrorMessage = "A név megadása kötelező!"), MaxLength(60), Column(TypeName = "VARCHAR")]
        public string Nev { get; set; }
        [Display(Name = "Születési dátum:")]
        [Column(TypeName = "DATE")]
        [Nagykoru]
        public DateTime? SzuletesiDatum { get; set; }
        public bool HirlevelFeliratkozas { get; set; } = false;
        [Display(Name = "Válassz előfizetés típust:")]
        [ForeignKey("ElofizetesTipus")]
        public int ElofizetesTipusId { get; set; }
        public ElofizetesTipus ElofizetesTipus { get; set; }
    }
}