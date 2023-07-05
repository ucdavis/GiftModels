using System;
using System.Text;

namespace GiftModels
{
    /// <summary>
    /// Class to allow multiple premiums per gift.
    /// </summary>
    public class PremiumDetails
    {
        /// <summary>
        /// Indicates if the donor has refused the premium
        /// </summary> 
        public bool Declined { get; set; }

        /// <summary>
        ///  This is the receipt number of the primary gift to which this premium corresponds. This must be a valid entry in the gift and primary_gift tables. 
        /// </summary>
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// This code is validated against the tms_premium table (W3). It describes the specific premium received. 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///This is the sequence number for each unique premium row. 
        /// </summary>
        public string SequenceNumber { get; set; }

        private string _commentOnly;
        /// <summary>
        /// The free text comment line (see below) less the KFS Chart and Account number and double square brackets, i.e. [[3-1234567(-sub_account)]].
        /// </summary>
        public string CommentOnly
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Comment))  // Meaning we have nothing to work with so return null.
                    return null;

                if (string.IsNullOrWhiteSpace(_commentOnly))
                {
                    InitAccountDetails();
                }
                
                return _commentOnly;
            }
        }

        /// <summary>
        /// This is a free text comment line about this premium containing the KFS Chart and Account number separated by a dash, included in double square brackets, i.e. [[3-1234567(-sub_account)]].
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        ///This is the KFS Chart number used to credit the back the premium amount. 
        /// </summary>
        private string _chart;
        public string Chart
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_chart) && string.IsNullOrWhiteSpace(Comment))
                    return null;
                if (string.IsNullOrWhiteSpace(_chart))
                {
                    InitAccountDetails();
                }

                return _chart;
            }
        }

        /// <summary>
        ///This is the KFS Account number used to credit the back the premium amount. 
        /// </summary>
        private string _account;

        public string Account
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_account) && string.IsNullOrWhiteSpace(Comment))
                    return null;
                if (string.IsNullOrWhiteSpace(_account))
                {
                    InitAccountDetails();
                }

                return _account;
            }
        }

        /// <summary>
        ///This is the KFS Sub-account number used to credit the back the premium amount. 
        /// </summary>
        private string _subAccount;

        public string SubAccount
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_subAccount) && string.IsNullOrWhiteSpace(Comment))
                    return null;
                if (string.IsNullOrWhiteSpace(_subAccount))
                {
                    InitAccountDetails();
                }
                    
                return _subAccount;
            }
        }

        /// <summary>
        /// This field is defaulted from the tms_premium table (W3). It is the monetary value associated with this premium. This value is normally the same amount as the value in the tms_premium table. 
        /// </summary>
        public decimal Amount { get; set; }

        private string _embeddedKfsAccountString;
        /// <summary>
        /// Parse out the KFS chart, Account, and Sub-account (if present) from the XComment field. 
        /// </summary>
        private void InitAccountDetails()
        {
            const string sPattern = @"\[\[(\w)-(\w{5,7})-?(\w{5})?\]\]";
            var result = System.Text.RegularExpressions.Regex.Match(Comment, sPattern);

            // entire account info
            _embeddedKfsAccountString = result.Groups[0].ToString();

            if (result.Groups[1].ToString().Length > 0 && result.Groups[2].ToString().Length > 0)
            {
                _chart = result.Groups[1].ToString();

                _account = result.Groups[2].ToString();

                _subAccount = result.Groups[3].ToString();

                if (string.IsNullOrWhiteSpace(_subAccount))
                {
                    _subAccount = "-----";
                }
            }

            //Sample: Jacket[[3-WINKLER]]Aggies
            _commentOnly = Comment;  // Set the _commentOnly to the same value as the Comment by default:
            
            // Check if there's embedded KFS Account details in the comment, and remove it from the remaining comments:
            if (!string.IsNullOrEmpty(_embeddedKfsAccountString)) //, i.e., [[3-WINKLER]]
            {
                // Get the segments before and after the KFS Account details as applicable:
                var segments = Comment.Split(new string[] {_embeddedKfsAccountString}, StringSplitOptions.RemoveEmptyEntries);
                // , i.e., [Jacket, Aggies]
                // But wait.  There may be spaces before or after each segment.  We'll need to remove these, 
                // but add a space between segments as applicable:
                var sb = new StringBuilder();
                foreach (var segment in segments)
                {
                    sb.Append(segment.Trim()); // Remove any leading or trailing whitespace for each segment.
                    sb.Append(' '); // Add a space after each segment.
                }
                // Lastly, remove the last, and final trailing space that was added above:
                _commentOnly = sb.ToString().Trim();
            }
        }
    }
}
