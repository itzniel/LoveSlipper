using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LoveSlipper.Models
{
    public class Slipper
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
    }
}
