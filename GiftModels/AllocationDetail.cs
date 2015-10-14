using System;
using System.ComponentModel.DataAnnotations;

namespace GiftModels
{
    public class AllocationDetail
    {
        [Required]
        public string AllocationCode { get; set; }

        /// <summary>
        /// The Allocation "Type", is predominantly "one blank space", but could also be
        /// Grants ("GT"), Gift in Kind ("GIK"), Planned Giving ("PG"), Suspense Hold ("SPH"), etc.
        /// We will use this field to help determine if a gift with particular Allocation attributes
        /// should be processed. Basically this field must be blank for Regents current use,
        /// Regents Endowment, and Regents Quasi (FFE). None of the other types listed above are allowed.
        /// </summary>
        public string AllocationType { get; set; }

        /// <summary>
        /// Indicates whether an AllocationCode is Active.  Used to determine a gift's allocation's acceptance criteria.
        /// We will use this field to help determine if a gift with particular Allocation attributes
        /// should be processed. 
        /// </summary>
        public bool IsActiveAllocation { get; set; }

        public string Account { get; set; }
        public string LongName { get; set; }
        public string DisplayName
        {
            get
            {
                var result = "";
                var allocationAndAccount = string.Format("{0}/{1}", AllocationCode, Account);
                allocationAndAccount = allocationAndAccount.Trim(' ', '/');
                result = string.IsNullOrWhiteSpace(LongName) ? allocationAndAccount : string.Format("{0} ({1})", allocationAndAccount, LongName);

                return result.Trim(' ');
            }
        }
        public string FundName { get; set; }
        public string DepartmentCode { get; set; }
        public string SchoolCode { get; set; }
        public string DivisionCode { get; set; }

        /// <summary>
        /// The College (or School) who receives the 4% College/School gift fee.
        /// </summary>
        public string BenefittingUnitCode { get; set; }
        public string UcFundCode { get; set; }

        /// <summary>
        /// F: Foundation
        /// R: Regents
        /// </summary>
        public string Agency { get; set; }
        public string Purpose { get; set; }

        public string PurposeDescription { get; set; }

        /// <summary>
        /// Catch all field
        /// </summary>
        public string ExtraReference { get; set; }

        /// <summary>
        /// Intended to be used for Foundation Endowments and Quasi allocations in order to determine whether 
        /// gift is to be funded to Short Term Investment Pool (STIP) or General Endowment Pool (GEP).
        /// 1: STIP (Short Term Investment Pool);
        /// 2: GEP (General Endowment Pool)
        /// </summary>
        public string EndowmentPoolCode { get; set; }

        /// <summary>
        /// Returns true is an allocation is funded to the Short Term Investment Pool (STIP); false otherwise.
        /// </summary>
        public bool IsShortTermInvestmentPool
        {
            get
            {
                if (string.Equals(EndowmentPoolCode, ("1")))
                    return true;
                
                return false;
            }
        }

        /// <summary>
        /// Returns true is an allocation is funded to the General Endowment Pool (GEP); false otherwise.
        /// </summary>
        public bool IsGeneralEndowmentPool
        {
            get
            {
                if (string.Equals(EndowmentPoolCode, ("2")))
                    return true;

                return false;
            }
        }

        #region Kfs Properties
        public string KfsAccount { get; set; }
        #endregion
    }
}