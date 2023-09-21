namespace SOLID.SRP.Example1.Correct
{
    internal class Invoice
    {
        private Book book;
        private int quantity;
        private double discountRate;
        private double taxRate;
        private double total;

        public Invoice(Book book, int quantity, double discountRate, double taxRate)
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
    }
}
