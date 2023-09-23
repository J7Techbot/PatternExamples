namespace Facade.SubSystems
{
    internal class Payment
    {
        public bool VerifyConnection()
        {
            //check if user can continue to payment
            return true;
        }
        public bool Pay(double totalCount)
        {
            //Pay for order
            return true;
        }

        public void CreateInvoice(double totalCount)
        {
            Console.WriteLine($"Objednávka zaplacena, faktura vygenerována.Výsledná cena za zboží: {totalCount}");
        }
    }
}
