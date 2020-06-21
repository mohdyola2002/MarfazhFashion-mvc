using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarfazahFashion.Dtos
{
    public class NewPurchaseDto
    {
        public int CustomerId { get; set; }
        public List<int> CurtainIds { get; set; }
    }
}