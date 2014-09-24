namespace GiftModels
{
    public class GiftDetails
    {
        public GiftDetails()
        {
            PrimaryDonor = new DonorContainer();
            Allocations = new AllocationContainer[0];
        }

        public DonorContainer PrimaryDonor { get; set; }

        public AllocationContainer[] Allocations { get; set; }

        public PaymentContainer Payment { get; set; }

        public string SpecialInstructions { get; set; }
    }
}