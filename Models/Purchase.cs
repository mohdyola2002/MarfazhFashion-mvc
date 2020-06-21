using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarfazahFashion.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Curtain Curtain { get; set; }
        
        public DateTime DatePurchased { get; set; }
        
    }
}