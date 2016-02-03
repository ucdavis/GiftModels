using System.Collections.Generic;
using System.Text;

namespace GiftModels
{
    public class DonorContainer
    {
        /// <summary>
        /// Differentiate associates, pets, emtpy acknowledgements, etc
        /// </summary>
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

        /// <summary>
        /// Get Advance acknowledgement type
        /// </summary>
        /// <returns>Acknowledgement Type (e.g. IHO/IMO)</returns>
        public string AcknowledgementType
        {
            get
            {
                var ret_val = string.Empty;

                if (Acknowledgement != null)
                {
                    if (Affiliate != null && Affiliate.IsPet)
                    {
                        switch (Affiliate.AffiliateType)
                        {
                            case "A":
                                ret_val = "IMO";
                                break;
                            case "H":
                                ret_val = "IHO";
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (GiftAssociatedCode)
                        {
                            case "M":
                                ret_val = "IMO";
                                break;
                            case "H":
                                ret_val = "IHO";
                                break;
                            default:
                                break;
                        }
                    }
                }

                return ret_val;
            }
        }

    }
}