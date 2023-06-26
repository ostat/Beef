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
    /// Represents the Term Deposit Account entity.
    /// </summary>
    public partial class TermDepositAccount
    {
        /// <summary>
        /// Gets or sets the Lodgement Date.
        /// </summary>
        public DateTime LodgementDate { get; set; }

        /// <summary>
        /// Gets or sets the Maturity Date.
        /// </summary>
        public DateTime MaturityDate { get; set; }

        /// <summary>
        /// Gets or sets the Maturity Amount.
        /// </summary>
        public decimal MaturityAmount { get; set; }

        /// <summary>
        /// Gets or sets the Maturity Currency.
        /// </summary>
        public string? MaturityCurrency { get; set; }

        /// <summary>
        /// Gets or sets the Maturity Instructions.
        /// </summary>
        public string? MaturityInstructions { get; set; }
    }
}