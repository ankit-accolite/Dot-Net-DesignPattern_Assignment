using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDiscountDesign
{
    public class CommercialCardUser : ShoppingDiscount
    {
        public double giveDiscount()
        {
            Console.WriteLine("\nCommercial Card User Gets Corporate Discount : 30% ");
            return .30;
        }
    }
}
