# Get updates from main source repository

1.) Add the remote, call it "upstream": `git remote add upstream https://github.com/JKorf/Binance.Net.git`  
2.) Fetch all the branches of that remote into remote-tracking branches, such as upstream/main: `git fetch upstream`  
3.) Make sure that you're on your master branch: `git checkout master`  
4.) Optional: Rewrite your main branch so that any commits of yours that aren't already in upstream/main are replayed on top of that other branch: `git rebase upstream/master`  
5.) Merge upstream/main into your main branch: `git merge upstream/master`
6.) Push your updated main branch to origin: `git push origin master`

## Broker
Spot: MHU2UUW8
Futures: yXxTdxJM

Binance.Net.BinanceExchange to be changed
internal const string ClientOrderIdSpot = "x-VICEW9VV";
internal const string ClientOrderIdFutures = "x-d63tKbx3";

BinanceRestClientUsdFuturesApi ctor
BinanceRestClientSpotApi ctor
Spot: PlaceOrderInternal() -> newClientOrderId
USD: PlaceOrderAsync() -> newClientOrderId
COIN: PlaceOrderAsync() -> newClientOrderId

-- broker commission methods
Binance.Net.Clients.GeneralApi.GetCommissionRebateStatusAsync