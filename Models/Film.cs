using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP220214V4.Models
{
    [Table("Filmek")]
    public class Film
    {
        [Key, Required]
        public int Id { get; set; }
        [MaxLength(60), Column(TypeName = "VARCHAR")]
        public string EredetiCim { get; set; }
        [MaxLength(60), Column(TypeName = "VARCHAR")]
        public string MagyarCim { get; set; }
        public int MegjelenesiEv { get; set; }
        [MaxLength(60), Column(TypeName = "VARCHAR")]
        //~/Content/imgs/cover_imgs/
        public string Kep { get; set; }
        public bool Korhataros { get; set; }
    }
}