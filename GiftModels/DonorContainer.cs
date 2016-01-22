namespace GiftModels
{
    public class DonorContainer
    {
        public string DonorType { get; set; }

        public DonorDetail Detail { get; set; }

        public Affiliate Affiliate { get; set; }

        public Acknowledgement Acknowledgement { get; set; }

        public decimal Amount { get; set; }

        public decimal CreditAmount { get; set; }

        /// <summary>
        /// Used to indicate if this donor is honorary, memorial, etc
        /// P: Primary
        /// M: In Memory of
        /// H: In Honor of
        /// O: Other
        /// </summary>
        public string GiftAssociatedCode { get; set; }

        public string Anonymous { get; set; }

    }
}