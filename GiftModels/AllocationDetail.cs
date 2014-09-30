namespace GiftModels
{
    public class AllocationDetail
    {
        public string AllocationCode { get; set; }
        public string Account { get; set; }
        public string LongName { get; set; }
        public string DisplayName { get; set; }
        public string FundName { get; set; }
        public string DeptartmentCode { get; set; }
        public string SchoolCode { get; set; }

        /// <summary>
        /// F: Foundation
        /// R: Regents
        /// </summary>
        public string Agency { get; set; }
    }
}