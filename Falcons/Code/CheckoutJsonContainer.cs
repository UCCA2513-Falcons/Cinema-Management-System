using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Code
{
    public class CheckoutJsonContainer
    {
        public List<CheckoutMenu> CheckoutMenus { get; set; }
        public List<CheckoutProduct> Products { get; set; }
    }
}
