using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarfazahFashion.Dtos
{
    public class CurtainDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public int Price { get; set; }

        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public int CurtainTypeId { get; set; }
    }
}