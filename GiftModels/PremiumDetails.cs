using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftModels
{
    /// <summary>
    /// Class to allow multiple premiums per gift.
    /// </summary>
    public class PremiumDetails
    {
        /// <summary>
        ///  This is the receipt number of the primary gift to which this premium corresponds. This must be a valid entry in the gift and primary_gift tables. 
        /// </summary>
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// This code is validated against the tms_premium table (W3). It describes the specific premium received. 
        /// </summary>
        public string PremiumCode { get; set; }

        /// <summary>
        ///This is the sequence number for each unique premium row. 
        /// </summary>
        public string SequenceNumber { get; set; }

        /// <summary>
        /// This is a free text comment line about this premium containing the KFS Chart and Account number separated by a dash, i.e. 3-1234567.
        /// </summary>
        public string Xcomment { get; set; }

        /// <summary>
        ///This is the KFS Chart number used to credit the back the premium amount. 
        /// </summary>
        private string _premiumChart;
        public string PremiumChart
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_premiumChart) && string.IsNullOrWhiteSpace(Xcomment))
                    return null;
                if (string.IsNullOrWhiteSpace(_premiumChart))
                    return Xcomment.Substring(0, Xcomment.IndexOf('-'));
                return _premiumChart;
            }
            set { _premiumChart = value; }
        }

        /// <summary>
        ///This is the KFS Account number used to credit the back the premium amount. 
        /// </summary>
        private string _premiumAccount;
        public string PremiumAccount
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_premiumAccount) && string.IsNullOrWhiteSpace(Xcomment))
                    return null;
                if (string.IsNullOrWhiteSpace(_premiumAccount))
                    return Xcomment.Substring(Xcomment.IndexOf('-') + 1);
                return _premiumAccount;
            }
            set { _premiumAccount = value; }
        }

        /// <summary>
        /// This field is defaulted from the tms_premium table (W3). It is the monetary value associated with this premium. This value is normally the same amount as the value in the tms_premium table. 
        /// </summary>
        public decimal PremiumAmount { get; set; }
    }
}
