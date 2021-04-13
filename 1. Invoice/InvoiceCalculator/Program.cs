namespace InvoiceCalculator
{
    using System;
    using System.Text;
    using InvoiceCalculator.Services;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ReadInput();
        }

        private static void ReadInput()
        {
            IreaderService reader = new ReaderService();
            ICalculateMMSAndSMSFeeService SMSAndMMSFee = new CalculateMMSAndSMSFeeService();
            var builder = new CalculateInvoiceBuilderService(reader, SMSAndMMSFee);
            while (true)
            {
                try
                {
                    builder
                    .AddMontlyFee()
                    .AddSendedSMS()
                    .AddSendedMMS()
                    .AddMinutesToA1NotInThePacket()
                    .AddMinutesToTelenorNotInThePacket()
                    .AddMinutesToVivacomNotInThePacket()
                    .AddMinutesRouming()
                    .AddUsedMBInCountryNotInThePacket()
                    .AddUsedMBInEuropeanUnionNotInThePacket()
                    .AddUsedMBOutsideEuropeanUnionNotInThePacket()
                    .AddOtherTaxes()
                    .AddDiscount()
                    .Result();

                    Console.WriteLine(GlobalConstants.GlobalConstants.Delimiter);
                }
                catch (Exception e)
                {
                    Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNotSupportedFormat);
                    Console.WriteLine(GlobalConstants.GlobalConstants.Delimiter);
                }
            }
        }
    }
}
