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
        [MaxLength(60), Column(TypeName = "VARCHAR")]
        public string Nev { get; set; }
        [Display(Name = "Születési dátum:")]
        [Column(TypeName = "DATE")]
        public DateTime SzuletesiDatum { get; set; }
        public bool Nagykoru => DateTime.Now.AddYears(-18) >= SzuletesiDatum;
        public bool HirlevelFeliratkozas { get; set; } = false;
        [Display(Name = "Válassz előfizetés típust:")]
        [ForeignKey("ElofizetesTipus")]
        public int ElofizetesTipusId { get; set; }
        public ElofizetesTipus ElofizetesTipus { get; set; }
    }
}