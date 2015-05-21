namespace GiftModels
{
    public class AllocationDetail
    {
        public string AllocationCode { get; set; }
        public string Account { get; set; }
        public string LongName { get; set; }
        public string DisplayName
        {
            get
            {
                var result = "";
                if (!string.IsNullOrWhiteSpace(AllocationCode))
                {
                    result += AllocationCode + "/";
                }
                if (!string.IsNullOrWhiteSpace(Account))
                {
                    result += Account + " ";
                }
                if (!string.IsNullOrWhiteSpace(LongName))
                {
                    result += string.Format("({0})", LongName);
                }
                return result.Trim(' ', '/');
            }
        }
        public string FundName { get; set; }
        public string DepartmentCode { get; set; }
        public string SchoolCode { get; set; }

        /// <summary>
        /// F: Foundation
        /// R: Regents
        /// </summary>
        public string Agency { get; set; }
        public string Purpose { get; set; }

        #region Kfs Properties
        public string KfsAccount { get; set; }
        #endregion
    }
}