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

        /// <summary>
        /// Date of first payment
        /// </summary>
        public DateTime? InitialPayDate { get; set; }

        /// <summary>
        /// First payment amount
        /// </summary>
        public decimal InitialPayAmont { get; set; }

        /// <summary>
        /// Total Count of frequency periods
        /// </summary>
        public int PeriodCount { get; set; }
    }
}
