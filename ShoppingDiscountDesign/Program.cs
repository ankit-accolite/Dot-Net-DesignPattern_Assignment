namespace ShoppingDiscountDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Shopping Amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            //For No Card User
            DiscountContext discountContext = new DiscountContext();
            double discount = discountContext.giveDiscount();
            double discountAmount = (discount != 0.0) ? (amount * discount) : 0;
            Console.WriteLine("Discount Amount : Rs" + discountAmount);
            Console.WriteLine("Paybale Amount : Rs" + (amount - discountAmount));

            //For Employee Card User
            discountContext = new DiscountContext(new EmployeeCardUser());
            discount = discountContext.giveDiscount();
            discountAmount = (discount != 0.0) ? (amount * discount) : 0;
            Console.WriteLine("Discount Amount : Rs" + discountAmount);
            Console.WriteLine("Paybale Amount : Rs" + (amount - discountAmount));

            //For Membership Card User
            discountContext = new DiscountContext(new MembershipCardUser());
            discount = discountContext.giveDiscount();
            discountAmount = (discount != 0.0) ? (amount * discount) : 0;
            Console.WriteLine("Discount Amount : Rs" + discountAmount);
            Console.WriteLine("Paybale Amount : Rs" + (amount - discountAmount));

            //For Commercial Card User
            discountContext = new DiscountContext(new CommercialCardUser());
            discount = discountContext.giveDiscount();
            discountAmount = (discount != 0.0) ? (amount * discount) : 0;
            Console.WriteLine("Discount Amount : Rs" + discountAmount);
            Console.WriteLine("Paybale Amount : Rs" + (amount - discountAmount));
        }
    }
}
