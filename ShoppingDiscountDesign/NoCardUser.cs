namespace ShoppingDiscountDesign
{
    internal class NoCardUser : ShoppingDiscount
    {
        public double giveDiscount()
        {
            Console.WriteLine("\nNO Card User Gets NO Discount !!");
            return 0.0;
        }
    }
}