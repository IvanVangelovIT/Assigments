namespace InvoiceCalculator.Services
{
    public class CalculateMMSAndSMSFeeService : ICalculateMMSAndSMSFeeService
    {
        private const decimal SMSUnderFiftyFee = 0.18M;
        private const decimal SMSBetweenFiftyAndOneHundredFee = 0.16M;
        private const decimal SMSMoreThanOneHundredFee = 0.11M;

        private const decimal MMSUnderFiftyFee = 0.25M;
        private const decimal MMSBetweenFiftyAndOneHundredFee = 0.23M;
        private const decimal MMSMoreThanOneHundredFee = 0.18M;
        public decimal CalculateMMSFee(int sendedMMS)
        {
            if (sendedMMS < 50)
            {
                return sendedMMS * MMSUnderFiftyFee;
            }
            else if (sendedMMS >= 50 && sendedMMS <= 100)
            {
                return sendedMMS * MMSBetweenFiftyAndOneHundredFee;
            }

            return sendedMMS * MMSMoreThanOneHundredFee;
        }
        public decimal CalculateSMSFee(int sendedSMS)
        {
            if (sendedSMS < 50)
            {
                return sendedSMS * SMSUnderFiftyFee;
            }
            else if (sendedSMS >= 50 && sendedSMS <= 100)
            {
                return sendedSMS * SMSBetweenFiftyAndOneHundredFee;
            }

            return sendedSMS * SMSMoreThanOneHundredFee;
        }
    }
}
