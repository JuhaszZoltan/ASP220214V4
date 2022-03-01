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
        public string Nev { get; set; }
        public DateTime? SzuletesiDatum { get; set; }
        public bool HirlevelFeliratkozas { get; set; }
        public int ElofizetesTipusId { get; set; }
    }
}