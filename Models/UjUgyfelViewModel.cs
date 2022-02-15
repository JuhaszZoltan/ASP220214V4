using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP220214V4.Models
{
    public class UjUgyfelViewModel
    {
        public Ugyfel Ugyfel { get; set; }
        public IEnumerable<ElofizetesTipus> ElofizetesTipusok { get; set; }
    }
}