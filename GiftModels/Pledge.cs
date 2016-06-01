using System;

namespace GiftModels
{
    public class Pledge
    {
        public string PledgeNumber { get; set; }

        public string PledgeType { get; set; }

        /// <summary>
        /// Total Amount Pledged
        /// </summary>
        public decimal Amount { get; set; }

        public string Frequency { get; set; }

        public string FrequencyDetails { get; set; }

        public DateTime? InitialPayDate { get; set; }

        /// <summary>
        /// Amount to be paid per frequency period
        /// </summary>
        public decimal PeriodAmount { get; set; }

        /// <summary>
        /// Total Count of frequency periods
        /// </summary>
        public int PeriodCount { get; set; }
    }
}
