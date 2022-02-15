using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP220214V4.Models
{
    [Table("Mufajok")]
    public class Mufaj
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [MaxLength(20), Column(TypeName = "VARCHAR")]
        public string Megnevezes { get; set; }
    }
}