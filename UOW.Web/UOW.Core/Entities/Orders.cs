using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOW.Core.Entities
{
    public class Orders
    {
        public String OrderID { get; set; }
        public String CustomerID { get; set; }
        public String OrderDate { get; set; }
        public String RequiredDate { get; set; }
        public String ShippedDate { get; set;}
        public String Freight { get; set; }
        public String ShipAddres { get; set; }
    }
}
