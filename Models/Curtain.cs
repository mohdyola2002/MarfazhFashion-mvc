using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarfazahFashion.Models
{
    public class Curtain
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        public int Price { get; set; }
        public int NumberInStock { get; set; }
    }
}