﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GiftModels.Helpers;

namespace GiftModels
{
    /// <summary>
    /// Base model for containing detail about a gift, including donor and allocation info 
    /// </summary>
    public class GiftDetails
    {
        public GiftDetails()
        {
            PrimaryDonor = new DonorContainer();
            AdditionalDonors = new List<DonorContainer>();
            Distributions = new List<Distribution>();
            Attachments = new List<Attachment>();
            Premiums = new List<PremiumDetails>();
        }

        public string Source { get; set; }
        
        public string SourceId { get; set; }

        public DonorContainer PrimaryDonor { get; set; }

        public IList<DonorContainer> AdditionalDonors { get; set; }

        public AllocationDetail Allocation { get; set; }

        public IList<Distribution> Distributions { get; set; }

        public IList<Attachment> Attachments { get; set; } 

        public PaymentContainer Payment { get; set; }

        public string SpecialInstructions { get; set; }

        public string AppealCode { get; set; }

        public bool HasAfFee { get; set; }

        public string CampaignCode { get; set; }

        [Range(0.01, Double.MaxValue)]
        public decimal Amount { get; set; }

        public decimal CreditAmount { get; set; }

        public bool IsRecurring { get; set; }

        public string PledgeId { get; set; }

        /// <summary>
        /// Gift Fee Type Description
        /// </summary>
        public string GiftFeeType { get; set; }

        /// <summary>
        /// Gift Fee Type Lookup Code
        /// </summary>
        public string GiftFeeTypeCode { get; set; }

        /// <summary>
        /// The number of premiums associated with the gift.
        /// This value is pulled from PRIM_GIFT_PREMIUM_CNT field.
        /// </summary>
        public int NumPremiums { get; set; }

        /// <summary>
        /// The individual premiums associated with a gift.
        /// These values are pulled from GIFT_PREMIUM table. 
        /// </summary>
        public IList<PremiumDetails> Premiums { get; set; }

        #region Advance Properties
        public string AdvanceReceiptNumber { get; set; }
        public string AdvanceBatchNumber { get; set; }
        
        public DateTime? RecordDate { get; set; }

        #endregion

        #region Kfs Properties
        /// <summary>
        /// KFS Document Number
        /// </summary>
        public virtual string KfsDocumentNumber { get; set; }

        /// <summary>
        /// KFS Reference Key
        /// </summary>
        [Required]
        public virtual string KfsKey { get; set; }
        #endregion

        #region GREAT Properties
        public int? GreatId { get; set; }
        #endregion
    }
}
