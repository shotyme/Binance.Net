using Binance.Net.Clients;
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
        public static BinanceRestClient CreateClient(bool isTestNet, string key = null, string secret = null)
        {
            BinanceRestClient binanceClient;

            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(secret))
            {
                binanceClient = new BinanceRestClient(options =>
                {
                    options.Environment = isTestNet ? BinanceEnvironment.Testnet : BinanceEnvironment.Live;
                    options.AutoTimestamp = true;
                });
                
                return binanceClient;
            }

            binanceClient = new BinanceRestClient(options =>
            {
                options.Environment = isTestNet ? BinanceEnvironment.Testnet : BinanceEnvironment.Live;
                options.ApiCredentials = new ApiCredentials(key, secret);
                options.AutoTimestamp = true;
            });

            return binanceClient;
        }

        /// <summary>
        /// Creates a new instance of BinanceClient using a specific environment
        /// </summary>
        /// <param name="environment">The environment to use</param>
        /// <param name="key">The API key</param>
        /// <param name="secret">The API secret</param>
        /// <returns></returns>
        public static BinanceRestClient CreateClient(BinanceEnvironment environment, string key = null, string secret = null)
        {
            BinanceRestClient binanceClient;

            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(secret))
            {
                binanceClient = new BinanceRestClient(options =>
                {
                    options.Environment = environment;
                    options.AutoTimestamp = true;
                });

                return binanceClient;
            }

            binanceClient = new BinanceRestClient(options =>
            {
                options.Environment = environment;
                options.ApiCredentials = new ApiCredentials(key, secret);
                options.AutoTimestamp = true;
            });

            return binanceClient;
        }

        /// <summary>
        /// Creates a new instance of BinanceClient for demo trading
        /// </summary>
        /// <param name="key">The API key</param>
        /// <param name="secret">The API secret</param>
        /// <returns></returns>
        public static BinanceRestClient CreateDemoClient(string key = null, string secret = null)
        {
            return CreateClient(BinanceEnvironment.Demo, key, secret);
        }

        /// <summary>
        /// Creates a new instance of BinanceClient using the default or the testnet options
        /// </summary>
        /// <param name="isTestNet">Use testnet endpoints</param>
        /// <param name="credentials">The API key credentials</param>
        /// <returns></returns>
        public static BinanceRestClient CreateClient(bool isTestNet, ApiCredentials credentials)
        {
            var binanceClient = new BinanceRestClient(options =>
            {
                options.Environment = isTestNet ? BinanceEnvironment.Testnet : BinanceEnvironment.Live;
                options.ApiCredentials = credentials;
                options.AutoTimestamp = true;
            });

            return binanceClient;
        }
    }
}
