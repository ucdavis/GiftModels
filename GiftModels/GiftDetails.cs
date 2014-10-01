namespace GiftModels
{
    /// <summary>
    /// Base model for containing detail about a gift, including donor and allocation info 
    /// </summary>
    public class GiftDetails
    {
        public GiftDetails()
        {
            PrimaryDonor = new DonorContainer();
            AdditionalDonors = new DonorContainer[0];
            Allocations = new AllocationContainer[0];
        }

        public DonorContainer PrimaryDonor { get; set; }

        public DonorContainer[] AdditionalDonors { get; set; }

        public AllocationContainer[] Allocations { get; set; }

        public PaymentContainer Payment { get; set; }

        public string SpecialInstructions { get; set; }

        public string AppealCode { get; set; }
        public string CampaignCode { get; set; }

        public double Amount { get; set; }

        public double CreditAmount { get; set; }

        #region Advance Properties
        public string AdvanceReceiptNumber { get; set; }
        public string AdvanceBatchNumber { get; set; }
        #endregion
    }
}