namespace InvoiceCalculator.Services
{
    using System;

    public class ReaderService : IreaderService
    {
        public decimal ReaderDecimal()
        {
            decimal number = decimal.Parse(Console.ReadLine());

            return number;
        }

        public int ReaderInteger()
        {
            int number = int.Parse(Console.ReadLine());

            return number;
        }
    }
}
