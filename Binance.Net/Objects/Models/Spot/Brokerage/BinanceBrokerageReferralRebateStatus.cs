namespace Binance.Net.Objects.Models.Spot.Brokerage
{
    public class BinanceBrokerageReferralRebateStatus
    {
        /// <summary>
        /// Indicates if the broker receives a spot rebate for the user
        /// </summary>
        public bool ReceiveSpotRebate { get; set; }
        /// <summary>
        /// Indicates if the broker receives a futures rebate for the user
        /// </summary>
        public bool ReceiveFuturesRebate { get; set; }
        /// <summary>
        /// Error message for spot
        /// </summary>
        public string? SpotError { get; set; }
        /// <summary>
        /// Error message for futures
        /// </summary>
        public string? FuturesError { get; set; }
    }
}
