using MarfazahFashion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarfazahFashion.ViewModels
{
    public class CurtainFormViewModel
    {
        public IEnumerable<CurtainType> CurtainTypes { get; set; }
        public Curtain Curtain { get; set; }
        public string Title
        {
            get
            {
                if (Curtain != null && Curtain.Id != 0)
                    return "Edit Curtain";
                return "New Curtain";
            }
        }
    }
}