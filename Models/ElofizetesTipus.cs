using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP220214V4.Models
{
    [Table("ElofizetesTipusok")]
    public class ElofizetesTipus
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(10), DataType("VARCHAR")]
        public string Nev { get; set; }
        public int ElofizetoiDij { get; set; }
        public int ElofizetettHonapokSzama { get; set; }
        public int Kedvezmeny { get; set; }
    }
}