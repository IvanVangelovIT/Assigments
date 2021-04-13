using System;
namespace InvoiceCalculator.Models
{
    public interface InvoiceOriginalPacket
    {
        public decimal MonthlyFee { get; set; }
        public int SendedSMS { get; set; }
        public int SendedMMS { get; set; }
        public int MinutesRouming { get; set; }
        public decimal OtherTaxes { get; set; }
        public decimal Discount { get; set; }
    }
}
