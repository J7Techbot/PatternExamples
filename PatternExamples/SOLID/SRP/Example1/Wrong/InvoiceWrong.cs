namespace SOLID.SRP.Example1.Wrong
{
    internal class InvoiceWrong
    {
        private Book book;
        private int quantity;
        private double discountRate;
        private double taxRate;
        private double total;

        public InvoiceWrong(Book book, int quantity, double discountRate, double taxRate)
        {
            this.book = book;
            this.quantity = quantity;
            this.discountRate = discountRate;
            this.taxRate = taxRate;
            total = CalculateTotal();
        }


        public double CalculateTotal()
        {
            double price = (book.Price - book.Price * discountRate) * quantity;

            double priceWithTaxes = price * (1 + taxRate);

            return priceWithTaxes;
        }

        /// <summary>
        /// The SRP states that our class should only have a single reason to change,
        /// and that reason should be a change in the invoice calculation for our class. So if we wanted to change the printing format, 
        /// we would need to change the class. This is why we should not have printing logic mixed with business logic in the same class.
        /// </summary>
        public void PrintInvoice()
        {
            Console.WriteLine(quantity + "x " + book.Name + " " + book.Price + "$");
            Console.WriteLine("Discount Rate: " + discountRate);
            Console.WriteLine("Tax Rate: " + taxRate);
            Console.WriteLine("Total: " + total);
        }

        /// <summary>
        /// It is also an extremely common mistake to mix persistence logic with business logic.
        /// It could be saving to a database, making an API call, or other stuff related to persistence.
        /// </summary>
        /// <param name="filename"></param>
        public void saveToFile(string filename)
        {
            // Creates a file with given name and writes the invoice
        }
    }
}
