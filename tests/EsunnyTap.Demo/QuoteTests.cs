using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;
using EsunnyTap.Net;

namespace EsunnyTap.Demo;

public class QuoteTests
{
    [Test]
    [Explicit]
    public async Task Test()
    {
        Console.WriteLine($"TapQuoteApiVersion:{EsunnyTapApi.GetTapQuoteAPIVersion()}");

        int ret = 0;
        var api = EsunnyTapApi.CreateTapQuoteAPI(new TapAPIApplicationInfo() { AuthCode = "", KeyOperationLogPath = "" }, ref ret);
        if (ret != 0)
        {
            Console.WriteLine($"CreateTapQuoteAPI failed ret:{ret}");
            return;
        }

        var quoteSpi = new QuoteImpl();
        ret = api.SetAPINotify(quoteSpi);
        if (ret != 0)
        {
            Console.WriteLine($"SetAPINotify failed ret:{ret}");
            return;
        }
        ret = api.SetHostAddress("61.163.243.173", 7171);
        if (ret != 0)
        {
            Console.WriteLine($"SetHostAddress failed ret:{ret}");
            return;
        }
        ret = api.Login(
            new TapAPIQuoteLoginAuth()
            {
                UserNo = "ES",
                Password = "123456",
                ISDDA = EsunnyTapApi.APIYNFLAG_NO,
                ISModifyPassword = EsunnyTapApi.APIYNFLAG_NO,
            }
        );
        if (ret != 0)
        {
            Console.WriteLine($"Login failed ret:{ret}");
            return;
        }
        await quoteSpi.OnAPIReadyEvent.Take(1).ToTask();
        uint sessionId = 0;
        api.SubscribeQuote(
            ref sessionId,
            new TapAPIContract()
            {
                Commodity = new TapAPICommodity()
                {
                    CommodityNo = "HHI",
                    ExchangeNo = "HKEX",
                    CommodityType = EsunnyTapApi.TAPI_COMMODITY_TYPE_FUTURES,
                },
                ContractNo1 = "2512",
                CallOrPutFlag1 = EsunnyTapApi.TAPI_CALLPUT_FLAG_NONE,
                CallOrPutFlag2 = EsunnyTapApi.TAPI_CALLPUT_FLAG_NONE,
                StrikePrice2 = "",
                StrikePrice1 = "",
            }
        );
        var info = await quoteSpi.OnRtnQuoteEvent.Take(1).ToTask();
        Console.WriteLine($"OnRtnQuote info:{info}");
    }

    public class QuoteImpl : ITapQuoteAPINotify
    {
        public override void OnRspLogin(int errorCode, TapAPIQuotLoginRspInfo info)
        {
            Console.WriteLine($"OnRspLogin errorCode:{errorCode} info:{info}");
        }

        public override void OnDisconnect(int reasonCode)
        {
            Console.WriteLine($"OnDisconnect reasonCode:{reasonCode}");
        }

        public Subject<int> OnAPIReadyEvent { get; } = new();

        public override void OnAPIReady()
        {
            Console.WriteLine("OnAPIReady");
            OnAPIReadyEvent.OnNext(0);
        }

        public Subject<TapAPIQuoteWhole> OnRtnQuoteEvent { get; } = new();

        public override unsafe void OnRspSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIQuoteWhole info)
        {
            if (info is not null)
            {
                Span<double> askPrice = new Span<double>(info.QAskPrice.AsPointer(), 20);
                Span<ulong> askQty = new Span<ulong>(info.QAskQty.AsPointer(), 20);
                Span<double> bidPrice = new Span<double>(info.QBidPrice.AsPointer(), 20);
                Span<ulong> bidQty = new Span<ulong>(info.QBidQty.AsPointer(), 20);
                OnRtnQuoteEvent.OnNext(new TapAPIQuoteWhole(info));
            }
        }

        public override void OnRtnQuote(TapAPIQuoteWhole info)
        {
            OnRtnQuoteEvent.OnNext(new TapAPIQuoteWhole(info));
        }
    }
}
