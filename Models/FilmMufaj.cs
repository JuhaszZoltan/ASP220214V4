using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ASP220214V4.Models
{
    [Table("FilmMufajKapcsolo")]
    public class FilmMufaj
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.None), Column(Order = 0), ForeignKey("Film")]
        public int FilmId { get; set; }

        public Film Film { get; set; }
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.None), Column(Order = 1), ForeignKey("Mufaj")]
        public int MufajId { get; set; }
        public Mufaj Mufaj { get; set; }
    }
}