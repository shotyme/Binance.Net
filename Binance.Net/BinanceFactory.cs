using Binance.Net.Clients;
using Binance.Net.Enums;
using Binance.Net.Objects;
using CryptoExchange.Net.Authentication;

namespace Binance.Net
{
    public static class BinanceFactory
    {
        /// <summary>
        /// Creates a new instance of BinanceClient using the default or the testnet options
        /// </summary>
        /// <param name="isTestNet">Use testnet endpoints</param>
        /// <param name="key">The API key</param>
        /// <param name="secret">The API secret</param>
        /// <returns></returns>
        public static BinanceClient CreateClient(bool isTestNet, string key = null, string secret = null)
        {
            BinanceClient binanceClient;

            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(secret))
            {
                var o = new BinanceClientOptions
                {
                    UsdFuturesApiOptions = new BinanceApiClientOptions
                    {
                        TradeRulesBehaviour = TradeRulesBehaviour.ThrowError,
                        BaseAddress =
                            (isTestNet
                                ? BinanceApiAddresses.TestNet.UsdFuturesRestClientAddress
                                : BinanceApiAddresses.Default.UsdFuturesRestClientAddress) ?? string.Empty,
                        AutoTimestamp = true
                    },
                    CoinFuturesApiOptions = new BinanceApiClientOptions()
                    {
                        TradeRulesBehaviour = TradeRulesBehaviour.ThrowError,
                        BaseAddress =
                            (isTestNet
                                ? BinanceApiAddresses.TestNet.CoinFuturesRestClientAddress
                                : BinanceApiAddresses.Default.CoinFuturesRestClientAddress) ?? string.Empty,
                        AutoTimestamp = true
                    }
                };

                binanceClient = new BinanceClient(o);
                return binanceClient;
            }

            var options = new BinanceClientOptions
            {
                ApiCredentials = new ApiCredentials(key, secret),
                UsdFuturesApiOptions = new BinanceApiClientOptions
                {
                    TradeRulesBehaviour = TradeRulesBehaviour.ThrowError,
                    BaseAddress =
                        (isTestNet
                            ? BinanceApiAddresses.TestNet.UsdFuturesRestClientAddress
                            : BinanceApiAddresses.Default.UsdFuturesRestClientAddress) ?? string.Empty,
                    AutoTimestamp = true
                },
                CoinFuturesApiOptions = new BinanceApiClientOptions()
                {
                    TradeRulesBehaviour = TradeRulesBehaviour.ThrowError,
                    BaseAddress =
                        (isTestNet
                            ? BinanceApiAddresses.TestNet.CoinFuturesRestClientAddress
                            : BinanceApiAddresses.Default.CoinFuturesRestClientAddress) ?? string.Empty,
                    AutoTimestamp = true
                }
            };

            binanceClient = new BinanceClient(options);
            return binanceClient;
        }

        /// <summary>
        /// Creates a new instance of BinanceClient using the default or the testnet options
        /// </summary>
        /// <param name="isTestNet">Use testnet endpoints</param>
        /// <param name="credentials">The API key credentials</param>
        /// <returns></returns>
        public static BinanceClient CreateClient(bool isTestNet, ApiCredentials credentials)
        {
            BinanceClient binanceClient;

            var options = new BinanceClientOptions
            {
                ApiCredentials = credentials,
                UsdFuturesApiOptions = new BinanceApiClientOptions
                {
                    TradeRulesBehaviour = TradeRulesBehaviour.ThrowError,
                    BaseAddress =
                        (isTestNet
                            ? BinanceApiAddresses.TestNet.UsdFuturesRestClientAddress
                            : BinanceApiAddresses.Default.UsdFuturesRestClientAddress) ?? string.Empty,
                    AutoTimestamp = true
                },
                CoinFuturesApiOptions = new BinanceApiClientOptions()
                {
                    TradeRulesBehaviour = TradeRulesBehaviour.ThrowError,
                    BaseAddress =
                        (isTestNet
                            ? BinanceApiAddresses.TestNet.CoinFuturesRestClientAddress
                            : BinanceApiAddresses.Default.CoinFuturesRestClientAddress) ?? string.Empty,
                    AutoTimestamp = true
                }
            };

            binanceClient = new BinanceClient(options);
            return binanceClient;
        }

    }
}
