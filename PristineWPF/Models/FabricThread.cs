using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pristine.Models {
    public class FabricThread {
        public string Name { get; set; }
        public decimal RetailTotal { get; set; }
        public decimal Discount { get; set; }
        public bool DiscountAsPercent { get; set; }
        public decimal PaymentReceived { get; set; }
        public decimal Shipping { get; set; }

    }
}
