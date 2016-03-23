using System;

namespace GiftModels
{
    public class Pledge
    {
        public string PledgeNumber { get; set; }
        public string PledgeType { get; set; }

        public decimal Amount { get; set; }

        public string Frequency { get; set; }
        public DateTime? InitialPayDate { get; set; }
    }
}