using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftModels
{
    /// <summary>
    /// A collection of KFS details pertaining to a gift
    /// </summary>
    public class KfsDetails
    {
        /// <summary>
        /// An indication that the gift transaction was posted to the general ledger.
        /// Note that this will always be true when a record is returned. 
        /// </summary>
        public bool Posted { get; set; }

        /// <summary>
        /// The KFS Document Origin Code associated with the KFS transaction.
        /// The DocOriginCode and DocNumber uniquely identify a scrubber file. 
        /// The combination of the two must be unique across all time.
        /// </summary>
        public string DocOriginCode { get; set; }

        /// <summary>
        /// The KFS Document Number associated with the KFS transaction.
        /// The DocumentNumber must be unique across all time for a particular DocOriginCode.
        /// </summary>
        public string DocNumber { get; set; }

        /// <summary>
        /// The line item number associated with the KFS transaction used to distinguish it from any other transaction submitted on the same document.  
        /// This will be unique per DocOriginCode and DocNumber within a scrubber file.  
        /// The DocOriginCode, DocNumber and SequenceNumber uniquely identify a KFS transaction across all time.
        /// Note that there can be multiple document number contained within a single scrubber file, so the SequenceNumber by itself may not be unique.  
        /// It is only unique in combination with its corresponding DocOriginCode and DocNumber.
        /// </summary>
        public string SequenceNum { get; set; }

        /// <summary>
        /// The KFS Chart Number associated with the KFS transaction.
        /// </summary>
        public string Chart { get; set; }

        /// <summary>
        /// The KFS Account Number associated with the KFS transaction.
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// The KFS Balance Type Code associated with the KFS transaction:  
        /// A "CB" indicates that the transaction was provided on a GLCB scrubber document; 
        /// A "AC" indicates that the transaction was provided on a GLJV scrubber document.
        /// </summary>
        public string BalanceType { get; set; }

        /// <summary>
        /// A textual description used to help describe the transaction's purpose.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The actual dollar amount associated with the KFS transaction.
        /// Note that a negative amount indicates a credit transaction.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The ten (10) character KFS Key associated with the KFS transaction.
        /// This is also referred to as the (Organization) Tracking Number.
        /// </summary>
        public string KfsKey { get; set; }

        /// <summary>
        /// The eight (8) character Organization Reference ID associated with the KFS transaction.
        /// </summary>
        public string OrgReferenceNum { get; set; }

        /// <summary>
        /// The date the associated KFS transaction posted to the general ledger.
        /// </summary>
        public DateTime GlPostedDate { get; set; }
    }
}
