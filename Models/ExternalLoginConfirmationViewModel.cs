using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MarfazahFashion.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "National I.D")]
        public string NationalId { get; set; }

        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}
