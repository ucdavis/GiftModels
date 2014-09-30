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
            Allocations = new AllocationContainer[0];
            AdditionalDonors = new DonorContainer[0];
        }

        public DonorContainer PrimaryDonor { get; set; }

        public DonorContainer[] AdditionalDonors { get; set; }

        public AllocationContainer[] Allocations { get; set; }

        public PaymentContainer Payment { get; set; }

        public string SpecialInstructions { get; set; }
    }
}