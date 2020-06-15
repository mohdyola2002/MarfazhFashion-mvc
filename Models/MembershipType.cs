using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarfazahFashion.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short MinimumOrder { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte Customer = 1;
    }
}