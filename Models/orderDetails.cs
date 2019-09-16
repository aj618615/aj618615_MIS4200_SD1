using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aj618615_MIS4200_SD1.Models
{
    public class orderDetails
    {
        public int orderDetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }

        public int orderID { get; set; }
        public virtual order order { get; set; }

        public int productID { get; set; }
        public virtual product product { get; set; }

    }
}