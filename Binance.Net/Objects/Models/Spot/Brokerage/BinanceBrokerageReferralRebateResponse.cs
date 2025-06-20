

namespace Binance.Net.Objects.Models.Spot.Brokerage
{
    public class BinanceBrokerageReferralRebateResponse
    {
        /// <summary>
        /// The broker ID for futures
        /// </summary>
        [JsonPropertyName("brokerId")]
        public string BrokerId { get; set; }
        /// <summary>
        /// The broker ID for spot
        /// </summary>
        [JsonPropertyName("apiAgentCode")]
        public string ApiAgentCode { get; set; }
        /// <summary>
        /// If "ifNewUser" is true, this user is a new user, which means that he signed up Binance after the date you have the Link ID.
        /// </summary>
        [JsonPropertyName("ifNewUser")]
        public bool IfNewUser { get; set; }
        /// <summary>
        /// If "rebateWorking" is true, this user is qualified for API rebate, which means that this user doesn’t have a referral code or his VIP level is under VIP5.
        /// </summary>
        [JsonPropertyName("rebateWorking")]
        public bool RebateWorking { get; set; }
    }
}
