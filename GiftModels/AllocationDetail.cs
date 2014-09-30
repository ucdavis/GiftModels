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
                return string.Format("{0}/{1} ({2})", AllocationCode, Account, LongName);
            }
        }
        public string FundName { get; set; }
        public string DeptartmentCode { get; set; }
        public string SchoolCode { get; set; }

        /// <summary>
        /// F: Foundation
        /// R: Regents
        /// </summary>
        public string Agency { get; set; }
        public string Purpose { get; set; }
    }
}