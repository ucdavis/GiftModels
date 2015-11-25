namespace GiftModels
{
    public class Distribution
    {
        public string Id { get; set; }

        /// <summary>
        /// Valid Values: Null/Empty, Existing, New, NewWithPayment
        /// </summary>
        public string TransactionType { get; set; }

        public AllocationDetail AllocationDetail { get; set; }

        public Pledge Pledge { get; set; }

        public decimal Amount { get; set; }

        public string GiftFeeType { get; set; }
    }
}