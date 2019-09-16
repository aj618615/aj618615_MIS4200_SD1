using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aj618615_MIS4200_SD1.Models
{
    public class product
    {
        public int productID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        public ICollection<orderDetails> orderDetails { get; set; }





    }
}