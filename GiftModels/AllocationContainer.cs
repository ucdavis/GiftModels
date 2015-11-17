namespace GiftModels
{
    public class AllocationContainer
    {
        public decimal Amount { get; set; }

        public string PledgeNumber { get; set; }

        /// <summary>
        /// Valid Values: Null/Empty, Existing, New, NewWithPayment
        /// </summary>
        public string PledgeType { get; set; }

        public AllocationDetail Detail { get; set; }
    }
}