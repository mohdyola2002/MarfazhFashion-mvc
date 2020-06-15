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

        [Display(Name = "Number In Stock")]
        [Range(1, 20, ErrorMessage = "The number of the curtain in stock must be between 1 and 20")]
        public int NumberInStock { get; set; }

        public CurtainType CurtainType { get; set; }

        [Display(Name = "Type")]
        public int CurtainTypeId { get; set; }

    }
}