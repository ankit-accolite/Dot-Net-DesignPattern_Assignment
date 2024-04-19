using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDiscountDesign
{
    public class MembershipCardUser : ShoppingDiscount
    {
        public double giveDiscount()
        {
            Console.WriteLine("\nMembership Card User Gets Low Discount : 10% ");
            return .10;
        }
    }
}
