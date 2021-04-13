namespace InvoiceCalculator.Services
{
    public interface ICalculateMMSAndSMSFeeService
    {
        public decimal CalculateMMSFee(int sendedMMS);
        public decimal CalculateSMSFee(int sendedSMS);
    
    }
}
