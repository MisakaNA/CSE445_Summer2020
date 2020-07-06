using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceSystem
{
    class OrderClass
    {
        public string SenderID { get; set; }

        public long CardNo { get; set; }

        public int Amount { get; set; }

        //I add this property for price holding
        public int UnitPrice { get; set; }
    }
}
