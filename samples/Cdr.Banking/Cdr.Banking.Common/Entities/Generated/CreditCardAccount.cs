/*
 * This file is automatically generated; any changes will be lost. 
 */

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using CoreEx.Entities;

namespace Cdr.Banking.Common.Entities
{
    /// <summary>
    /// Represents the Credit Card Account entity.
    /// </summary>
    public partial class CreditCardAccount
    {
        /// <summary>
        /// Gets or sets the Min Payment Amount.
        /// </summary>
        public decimal MinPaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets the Payment Due Amount.
        /// </summary>
        public decimal PaymentDueAmount { get; set; }

        /// <summary>
        /// Gets or sets the Payment Currency.
        /// </summary>
        public string? PaymentCurrency { get; set; }

        /// <summary>
        /// Gets or sets the Payment Due Date.
        /// </summary>
        public DateTime PaymentDueDate { get; set; }
    }
}