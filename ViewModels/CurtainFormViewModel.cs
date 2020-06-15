using MarfazahFashion.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarfazahFashion.ViewModels
{
    public class CurtainFormViewModel
    {
        public IEnumerable<CurtainType> CurtainTypes { get; set; }
        [Required]
        public int? Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        public int? Price { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        [Range(1, 20, ErrorMessage = "The number of the curtain in stock must be between 1 and 20")]
        public int? NumberInStock { get; set; }

        [Required]
        [Display(Name = "Type")]
        public int? CurtainTypeId { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Curtain" : "New Curtain";
            }
        }

        public CurtainFormViewModel()
        {
            Id = 0;
        }

        public CurtainFormViewModel(Curtain curtain)
        {
            Id = curtain.Id;
            Name = curtain.Name;
            Price = curtain.Price;
            NumberInStock = curtain.NumberInStock;
            CurtainTypeId = curtain.CurtainTypeId;
        }
    }
}