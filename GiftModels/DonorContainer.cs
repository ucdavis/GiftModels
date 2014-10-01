namespace GiftModels
{
    public class DonorContainer
    {
        public DonorDetail Detail { get; set; }

        public double Amount { get; set; }

        public double CreditAmount { get; set; }

        /// <summary>
        /// Used to indicate if this donor is honorary, memorial, etc
        /// P: Primary
        /// M: In Memory of
        /// H: In Honor of
        /// O: Other
        /// </summary>
        public string GiftAssociatedCode { get; set; }
    }
}