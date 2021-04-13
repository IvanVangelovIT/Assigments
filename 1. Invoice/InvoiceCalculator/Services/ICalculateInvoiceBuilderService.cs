namespace InvoiceCalculator.Services
{
    public interface ICalculateInvoiceBuilderService
    {
        CalculateInvoiceBuilderService AddMontlyFee();
        CalculateInvoiceBuilderService AddSendedSMS();
        CalculateInvoiceBuilderService AddSendedMMS();
        CalculateInvoiceBuilderService AddMinutesToA1NotInThePacket();
        CalculateInvoiceBuilderService AddMinutesToTelenorNotInThePacket();
        CalculateInvoiceBuilderService AddMinutesToVivacomNotInThePacket();
        CalculateInvoiceBuilderService AddMinutesRouming();
        CalculateInvoiceBuilderService AddUsedMBInCountryNotInThePacket();
        CalculateInvoiceBuilderService AddUsedMBInEuropeanUnionNotInThePacket();
        CalculateInvoiceBuilderService AddUsedMBOutsideEuropeanUnionNotInThePacket();
        CalculateInvoiceBuilderService AddOtherTaxes();
        CalculateInvoiceBuilderService AddDiscount();
        void Result();
    }
}
