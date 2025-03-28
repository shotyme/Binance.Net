﻿using CryptoExchange.Net.Attributes;

namespace Binance.Net.Enums
{
    /// <summary>
    /// Transaction status
    /// </summary>
    public enum AutoInvestTransactionStatus
    {
        /// <summary>
        /// Success
        /// </summary>
        [Map("SUCCESS")]
        Success,
        /// <summary>
        /// Failed
        /// </summary>
        [Map("FAILED")]
        Failed,
        /// <summary>
        /// Pending
        /// </summary>
        [Map("PENDING")]
        Pending
    }
}
