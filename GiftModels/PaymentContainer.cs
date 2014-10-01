﻿using System;

namespace GiftModels
{
    public class PaymentContainer
    {
        public string Type { get; set; }
        public double? Amount { get; set; }
        public string CheckNumber { get; set; }

        #region Credit Card Properties
        /// <summary>
        /// Payment Gateway Transaction Authorization Time
        /// Generated by Processor, passed through from CyberSource
        /// </summary>
        public virtual DateTime CardAuthorizedAt { get; set; }

        /// <summary>
        /// 3 digit card type code (ex: visa == 001)
        /// </summary>
        public virtual string CardType { get; set; }

        /// <summary>
        /// Masked or Suffix of Account. May contain 'x's
        /// </summary>
        public virtual string CardNumber { get; set; }

        /// <summary>
        /// MM-YYYY
        /// </summary>
        public virtual DateTime CardExpiration { get; set; }

        /// <summary>
        /// Short Reply Code returned by processor (Chase/Visa/Etc) authorizing payment
        /// </summary>
        public virtual string CardAuthorizationCode { get; set; }

        /// <summary>
        /// Payment Processor (Chase/Visa/Etc) Transaction Id
        /// Generated by Processor, passed through from CyberSource
        /// </summary>
        public virtual string CardTransactionReferenceNumber { get; set; }
        #endregion

        /// <summary>
        /// KFS Reference Key
        /// </summary>
        public virtual string KfsKey { get; set; }
    }
}