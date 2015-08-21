using System.Linq;

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
                    InitAccounDetails();

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
                    InitAccounDetails();

                return _premiumAccount;
            }
            set { _premiumAccount = value; }
        }

        /// <summary>
        ///This is the KFS Sub-account number used to credit the back the premium amount. 
        /// </summary>
        private string _premiumSubAccount;

        public string PremiumSubAccount
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_premiumSubAccount) && string.IsNullOrWhiteSpace(Xcomment))
                    return null;
                if (string.IsNullOrWhiteSpace(_premiumAccount))
                    InitAccounDetails();

                return _premiumSubAccount;
            }
            set { _premiumSubAccount = value; }
        }

        /// <summary>
        /// This field is defaulted from the tms_premium table (W3). It is the monetary value associated with this premium. This value is normally the same amount as the value in the tms_premium table. 
        /// </summary>
        public decimal PremiumAmount { get; set; }

        /// <summary>
        /// Parse out the KFS chart, Account, and Sub-account (if present) from the XComment field. 
        /// </summary>
        private void InitAccounDetails()
        {
            const string sPattern = @"\[\[(\w)-(\w{5,7})-?(\w{5})?\]\]";
            var result = System.Text.RegularExpressions.Regex.Match(Xcomment, sPattern);

            if (result.Groups[1].Length > 0 && result.Groups[1].ToString().Length > 0)
            {
                _premiumChart = result.Groups[1].ToString();

                _premiumAccount = result.Groups[2].ToString();

                _premiumSubAccount = result.Groups[3].ToString();

                if (string.IsNullOrWhiteSpace(_premiumSubAccount))
                {
                    _premiumSubAccount = "-----";
                }
            }
        }
    }
}
