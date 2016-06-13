using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api2.Models
{
    public class Software
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Url { get; set; }
    }
}