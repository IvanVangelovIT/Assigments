namespace CsvFile.Data.Models
{
    /// <summary>
    /// Included Id for optimization purposes
    /// </summary>
    public class Offer
    {
        public int Id { get; set; }
        public int offerId { get; set; }
        public int monthlyFee { get; set; }
        public int newContractsForMonth { get; set; }
        public int sameContractsForMonth { get; set; }
        public int CancelledContractsForMonth { get; set; }
    }
}
