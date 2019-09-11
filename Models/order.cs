using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aj618615_MIS4200_SD1.Models
{
    public class order
    {
        public int orderID { get; set; }
        public int customerID { get; set; }
        public virtual customer customer { get; set; }
        public DateTime orderDate { get; set; }


    }
}