using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;
using EsunnyTap.Net;

namespace EsunnyTap.Demo;

public class TradeTests
{
    //[Test]
    public async Task Test()
    {
        Console.WriteLine($"TapTradeApiVersion:{EsunnyTapApi.GetTapTradeAPIVersion()}");

        int ret = 0;
        var api = EsunnyTapApi.CreateTapTradeAPI(new TapAPIApplicationInfo() { AuthCode = "", KeyOperationLogPath = "" }, ref ret);
        if (ret != 0)
        {
            Console.WriteLine($"CreateTapTradeAPI failed ret:{ret}");
            return;
        }

        var tradeSpi = new TradeImpl();
        ret = api.SetAPINotify(tradeSpi);
        if (ret != 0)
        {
            Console.WriteLine($"SetAPINotify failed ret:{ret}");
            return;
        }
        ret = api.SetHostAddress("123.161.206.213", 6160);
        if (ret != 0)
        {
            Console.WriteLine($"SetHostAddress failed ret:{ret}");
            return;
        }
        ret = api.Login(
            new TapAPITradeLoginAuth()
            {
                UserNo = "Q123456789",
                Password = "123456",
                AuthCode = "Demo_TestCollect",
                AppID = "Demo_TestCollect",
                ISDDA = EsunnyTapApi.APIYNFLAG_NO,
                ISModifyPassword = EsunnyTapApi.APIYNFLAG_NO,
                NoticeIgnoreFlag = EsunnyTapApi.TAPI_NOTICE_IGNORE_CLOSE | EsunnyTapApi.TAPI_NOTICE_IGNORE_POSITIONPROFIT,
            }
        );
        if (ret != 0)
        {
            Console.WriteLine($"Login failed ret:{ret}");
            return;
        }

        await tradeSpi.OnApiReadySubject.Take(1).ToTask();
        Console.WriteLine($"Login success");
    }

    public class TradeImpl : EsunnyTap.Net.ITapTradeAPINotify
    {
        public override void OnConnect()
        {
            Console.WriteLine("OnConnect");
        }

        public override void OnRspLogin(int errorCode, TapAPITradeLoginRspInfo loginRspInfo)
        {
            Console.WriteLine($"OnRspLogin errorCode:{errorCode} loginRspInfo:{loginRspInfo}");
        }

        public override void OnDisconnect(int reasonCode)
        {
            Console.WriteLine($"OnDisconnect reasonCode:{reasonCode}");
        }
public Subject<int> OnApiReadySubject = new();
        public override void OnAPIReady()
        {
            Console.WriteLine("OnAPIReady");
            OnApiReadySubject.OnNext(0);
        }
    }
}
