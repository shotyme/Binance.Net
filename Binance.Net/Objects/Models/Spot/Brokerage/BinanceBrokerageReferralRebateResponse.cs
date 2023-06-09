using Newtonsoft.Json;

namespace Binance.Net.Objects.Models.Spot.Brokerage
{
    public class BinanceBrokerageReferralRebateResponse
    {
        /// <summary>
        /// The broker ID for futures
        /// </summary>
        [JsonProperty("brokerId")]
        public string BrokerId { get; set; }
        /// <summary>
        /// The broker ID for spot
        /// </summary>
        [JsonProperty("apiAgentCode")]
        public string ApiAgentCode { get; set; }
        /// <summary>
        /// If "ifNewUser" is true, this user is a new user, which means that he signed up Binance after the date you have the Link ID.
        /// </summary>
        [JsonProperty("ifNewUser")]
        public bool IfNewUser { get; set; }
        /// <summary>
        /// If "rebateWorking" is true, this user is qualified for API rebate, which means that this user doesn’t have a referral code or his VIP level is under VIP5.
        /// </summary>
        [JsonProperty("rebateWorking")]
        public bool RebateWorking { get; set; }
    }
}
