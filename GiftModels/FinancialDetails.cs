using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftModels
{
    public class FinancialDetails
    {
        public virtual string KfsKey { get; set; }

        public string AdvanceReceiptNumber { get; set; }

        public virtual string PrimaryDonor { get; set; }

        public virtual string DonorId { get; set; }

        public virtual decimal TotalAmount { get; set; }

        public virtual decimal TotalPremiumAmount { get; set; }

        //TODO: This has yet to be implemented on the GivingSrvice end. Ultimately the NetGiftAmount will be PremiumAdjustedGiftAmount - TotalGiftFeeAmount.
        public virtual decimal TotalGiftFeeAmount { get; set; }

        public virtual string Prem { get; set; } // Y/N

        public virtual decimal PremiumAdjustedGiftAmount { get; set; }

        public virtual string AllocationCode { get; set; }

        public virtual string AllocationName { get; set; }

        public virtual string Agency { get; set; }

        public virtual string FundType { get; set; }

        public virtual string Purpose { get; set; }

        public virtual string FisAccount {
            get
            {
                string retval = null;
                if (string.Equals(FundType, "CURRENT", StringComparison.OrdinalIgnoreCase) && !(string.Equals(Purpose, "LOAN", StringComparison.OrdinalIgnoreCase) || string.Equals(Purpose, "CAPITAL", StringComparison.OrdinalIgnoreCase)))
                {
                    if (!string.IsNullOrWhiteSpace(ExpenseChart) && !string.IsNullOrWhiteSpace(ExpenseAccount))
                        retval =  ExpenseChart + "-" + ExpenseAccount;
                }
                else if (string.Equals(FundType, "QUASI", StringComparison.OrdinalIgnoreCase) || string.Equals(FundType, "ENDOWMENT", StringComparison.OrdinalIgnoreCase))
                {
                    retval = ExpenseAccount;
                    if (!string.IsNullOrWhiteSpace(retval) && retval.StartsWith("92"))
                    {
                        // Remove the "92"
                        retval = ExpenseAccount.Substring(2);
                    }
                }
                // else if (FundType.Equals("CURRENT") && Purpose.Equals("LOAN"))) return null;
                return retval;
            } 
        }

        public virtual string FisSubAccount { get; set; }

        public virtual string GiftFeeCode { get; set; }

        public virtual string GiftFeeExceptionName { get; set; }

        public virtual bool HasAfFee { get; set; } // Y/N

        public virtual string BenefittingUnitCode { get; set; }

        public virtual string BenefittingUnitName { get; set; }

        //public virtual DateTime JvBaDate { get; set; } //Great

        //public virtual string JvBaScrubberNumber { get; set; } //Great

        //public virtual string Comments { get; set; } //Great

        //public virtual string Status { get; set; } //Great

        //public virtual decimal GiftBalance { get; set; } //Great

        public virtual string UcFundChart { get; set; }

        public virtual string UcFundNumber { get; set; }

        public virtual string ScrubberChart { get; set; }

        public virtual string ScrubberAccount { get; set; }

        public virtual string RevenueChart { get; set; }

        public virtual string RevenueAccount { get; set; }

        public virtual IList<PremiumDetails> Premiums { get; set; }

        public virtual string ExpenseChart { get; set; }

        public virtual string ExpenseAccount { get; set; }

        public virtual string ExpenseSubAccount { get; set; }

        public virtual string GiftFeeChart { get; set; }

        public virtual string GiftFeeAccount { get; set; }

        public virtual DateTime CreationDate { get; set; } //Great?

        public virtual DateTime UpdateDate { get; set; } // Great?

        public virtual string EndowmentPoolCode { get; set; }

        public virtual string EndowmentPool
        {
            get
            {
                switch (EndowmentPoolCode)
                {
                    case "1":
                        return "STIP";
                    case "2":
                        return "GEP";
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// Returns true is an allocation is funded to the Short Term Investment Pool (STIP); false otherwise.
        /// </summary>
        public virtual bool IsShortTermInvestmentPool
        {
            get
            {
                return string.Equals(EndowmentPoolCode, ("1"));
            }
        }

        /// <summary>
        /// Returns true is an allocation is funded to the General Endowment Pool (GEP); false otherwise.
        /// </summary>
        public virtual bool IsGeneralEndowmentPool
        {
            get
            {
                return string.Equals(EndowmentPoolCode, ("2"));
            }
        }
    }
}
