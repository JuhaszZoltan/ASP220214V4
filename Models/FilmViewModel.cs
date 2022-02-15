using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP220214V4.Models
{
    public class FilmViewModel
    {
        public Film Film { get; set; }
        public List<Mufaj> Mufajok { get; set; }
    }
}