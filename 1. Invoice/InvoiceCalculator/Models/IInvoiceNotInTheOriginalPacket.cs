namespace InvoiceCalculator.Models
{
    public interface IInvoiceNotInTheOriginalPacket
    {
        public int MinutesToA1NotInThePacket { get; set; }
        public int MinutesToTelenorNotInThePacket { get; set; }
        public int MinutesToVivacomNotInThePacket { get; set; }
        public int UsedMBInCountryNotInThePacket { get; set; }
        public int UsedMBInEuropeanUnionNotInThePacket { get; set; }
        public int UsedMBOutsideEuropeanUnionNotInThePacket { get; set; }

    }
}
