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

        /// <summary>
        /// Gift Fee Type Description
        /// </summary>
        public string GiftFeeType { get; set; }

        /// <summary>
        /// Gift Fee Type Lookup Code
        /// </summary>
        public string GiftFeeTypeCode { get; set; }
    }
}