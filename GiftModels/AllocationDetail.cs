using System;
using System.ComponentModel.DataAnnotations;

namespace GiftModels
{
    public class AllocationDetail
    {
        [Required]
        public string AllocationCode { get; set; }
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

        #region Kfs Properties
        public string KfsAccount { get; set; }
        #endregion
    }
}