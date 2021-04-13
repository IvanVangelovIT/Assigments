namespace InvoiceCalculator.Models
{
    public interface IMobilePlanA1 : IInvoiceNotInTheOriginalPacket, InvoiceOriginalPacket
    {
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
       
    }
}
