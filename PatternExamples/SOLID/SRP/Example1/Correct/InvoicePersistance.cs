namespace SOLID.SRP.Example1.Correct
{
    internal class InvoicePersistance
    {
        Invoice invoice;

        public InvoicePersistance(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void SaveToFile(String filename)
        {
            // Logic to persistant save
        }
    }
}
