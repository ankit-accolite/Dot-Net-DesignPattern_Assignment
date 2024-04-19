using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingDiscountDesign
{
    internal class EmployeeCardUser : ShoppingDiscount
    {
        public double giveDiscount()
        {
            Console.WriteLine("\nEmployee Card User Gets High Discount : 20% ");
            return .20;
        }
    }
}
