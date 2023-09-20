namespace SOLID.SRP.Example1.Correct
{
    internal class InvoicePrinter
    {
        private Invoice invoice;

        public InvoicePrinter(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void PrintInvoice()
        {
            /// Logic to print invoice
        }
    }
}
