namespace InvoiceCalculator.Services
{
    using System;
    using InvoiceCalculator.Models;

    /// <summary>
    /// Factory Builder, used to calculate Invoice based on input parameters.
    /// </summary>
    public class CalculateInvoiceBuilderService : IMobilePlanA1, ICalculateInvoiceBuilderService
    {

        private const decimal MinutesA1OutsideThePacketFee = 0.03M;
        private const decimal MinutesOtherOperatorsOutsideThePacketFee = 0.09M;
        private const decimal MinutesRoumingOutsideThePacketFee = 0.15M;

        private const decimal MBInCountryOutsideThePacketFee = 0.02M;
        private const decimal MBEUropeanUnionOutsideThePacketFee = 0.05M;
        private const decimal MBOutsideEuropeanUnionOutsideThePacketFee = 0.20M;

        private decimal data;
        private int dataInt;
     
        private readonly IreaderService reader;
        private readonly ICalculateMMSAndSMSFeeService calculateMMSAndSMSFeeService;

        public CalculateInvoiceBuilderService(IreaderService reader, ICalculateMMSAndSMSFeeService calculateMMSAndSMSFeeService)
        {
            this.reader = reader;
            this.calculateMMSAndSMSFeeService = calculateMMSAndSMSFeeService;
        }
        public decimal MonthlyFee { get; set; }
        public int SendedSMS { get; set; }
        public int SendedMMS { get; set; }
        public int MinutesRouming { get; set; }
        public decimal OtherTaxes { get; set; }
        public decimal Discount { get; set; }
        public int MinutesToA1NotInThePacket { get; set; }
        public int MinutesToTelenorNotInThePacket { get; set; }
        public int MinutesToVivacomNotInThePacket { get; set; }
        public int UsedMBInCountryNotInThePacket { get; set; }
        public int UsedMBInEuropeanUnionNotInThePacket { get; set; }
        public int UsedMBOutsideEuropeanUnionNotInThePacket { get; set; }

        public CalculateInvoiceBuilderService AddDiscount()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.Discount);
            data = reader.ReaderDecimal();
            if (data < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddDiscount(); };
            Discount = data;

            return this;
        }

        public CalculateInvoiceBuilderService AddMinutesRouming()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.MinutesRouming);
            dataInt = reader.ReaderInteger();
            if (dataInt < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddMinutesRouming(); };
            MinutesRouming = dataInt;

            return this;
        }

        public CalculateInvoiceBuilderService AddMinutesToA1NotInThePacket()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.MinutesToA1NotInThePacket);
            dataInt = reader.ReaderInteger();
            if (dataInt < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddMinutesToA1NotInThePacket(); };
            MinutesToA1NotInThePacket = dataInt;

            return this;
        }

        public CalculateInvoiceBuilderService AddMinutesToTelenorNotInThePacket()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.minutesToTelenorNotInThePacket);
            dataInt = reader.ReaderInteger();
            if (dataInt < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddMinutesToTelenorNotInThePacket(); };
            MinutesToTelenorNotInThePacket = dataInt;

            return this;
        }

        public CalculateInvoiceBuilderService AddMinutesToVivacomNotInThePacket()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.MinutesToVivacomNotInThePacket);
            dataInt = reader.ReaderInteger();
            if (dataInt < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddMinutesToVivacomNotInThePacket(); };
            MinutesToVivacomNotInThePacket = dataInt;

            return this;
        }

        public CalculateInvoiceBuilderService AddMontlyFee()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.MonthlyFee);
            data = reader.ReaderDecimal();
            if (data < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddMontlyFee(); };
            MonthlyFee = data;

            return this;
        }

        public CalculateInvoiceBuilderService AddOtherTaxes()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.OtherTaxes);
            data = reader.ReaderDecimal();
            if (data < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddOtherTaxes(); };
            OtherTaxes = data;

            return this;
        }

        public CalculateInvoiceBuilderService AddSendedMMS()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.SendedMMS);
            dataInt = reader.ReaderInteger();
            if (dataInt < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddSendedMMS(); };
            SendedMMS = dataInt;

            return this;
        }

        public CalculateInvoiceBuilderService AddSendedSMS()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.SendedSMS);
            dataInt = reader.ReaderInteger();
            if (dataInt < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddSendedSMS(); };
            SendedSMS = dataInt;

            return this;
        }

        public CalculateInvoiceBuilderService AddUsedMBInCountryNotInThePacket()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.UsedMBInCountryNotInThePacket);
            dataInt = reader.ReaderInteger();
            if (data < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddUsedMBInCountryNotInThePacket(); };
            UsedMBInCountryNotInThePacket = dataInt;

            return this;
        }

        public CalculateInvoiceBuilderService AddUsedMBInEuropeanUnionNotInThePacket()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.UsedMBInEuropeanUnionNotInThePacket);
            dataInt = reader.ReaderInteger();
            if (dataInt < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddUsedMBInEuropeanUnionNotInThePacket(); };
            UsedMBInEuropeanUnionNotInThePacket = dataInt;

            return this;
        }

        public CalculateInvoiceBuilderService AddUsedMBOutsideEuropeanUnionNotInThePacket()
        {
            Console.WriteLine(GlobalConstants.GlobalConstants.UsedMBOutsideEuropeanUnionNotInThePacket);
            dataInt = reader.ReaderInteger();
            if (dataInt < 0) { Console.WriteLine(GlobalConstants.GlobalConstants.ErrorNegativeNumber); AddUsedMBOutsideEuropeanUnionNotInThePacket(); };
            UsedMBOutsideEuropeanUnionNotInThePacket = dataInt;

            return this;
        }

        public void Result()
        {
            decimal SMSFee = calculateMMSAndSMSFeeService.CalculateSMSFee(this.SendedSMS);
            decimal MMSFee = calculateMMSAndSMSFeeService.CalculateSMSFee(this.SendedMMS);

            var invoice = this.MonthlyFee
                + SMSFee
                + MMSFee
                + this.MinutesToA1NotInThePacket * MinutesA1OutsideThePacketFee
                + (this.MinutesToTelenorNotInThePacket + this.MinutesToVivacomNotInThePacket) * MinutesOtherOperatorsOutsideThePacketFee
                + this.MinutesRouming * MinutesRoumingOutsideThePacketFee
                + this.UsedMBInCountryNotInThePacket * MBInCountryOutsideThePacketFee
                + this.UsedMBInEuropeanUnionNotInThePacket * MBEUropeanUnionOutsideThePacketFee
                + this.UsedMBOutsideEuropeanUnionNotInThePacket * MBOutsideEuropeanUnionOutsideThePacketFee
                + this.OtherTaxes
                - this.Discount;

            Console.WriteLine(GlobalConstants.GlobalConstants.Result + Math.Round(invoice, 2));
        }
    }
}
