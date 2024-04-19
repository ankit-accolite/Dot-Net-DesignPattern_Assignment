using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDiscountDesign
{
    public class DiscountContext
    {
        public ShoppingDiscount discount { get; set; }

        public DiscountContext()
        {
            discount = new NoCardUser();
        }

        public DiscountContext(ShoppingDiscount discount)
        {
            this.discount = discount;
        }

        public double giveDiscount()
        {
            return discount.giveDiscount();
        }
    }
}
