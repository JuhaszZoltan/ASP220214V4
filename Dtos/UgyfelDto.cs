using ASP220214V4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP220214V4.Dtos
{
    public class UgyfelDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A név megadása kötelező!"), MaxLength(60)]
        public string Nev { get; set; }
        [Nagykoru]
        public DateTime? SzuletesiDatum { get; set; }
        public bool HirlevelFeliratkozas { get; set; }
        public int ElofizetesTipusId { get; set; }
    }
}