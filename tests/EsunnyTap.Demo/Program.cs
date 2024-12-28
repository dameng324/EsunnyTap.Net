// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;
using EsunnyTap.Net;

Console.WriteLine($"TapQuoteApiVersion:{EsunnyTapApi.GetTapQuoteAPIVersion()}");
Console.WriteLine($"TapTradeApiVersion:{EsunnyTapApi.GetTapTradeAPIVersion()}");

int ret = 0;
var api = EsunnyTapApi.CreateTapTradeAPI(
    new TapAPIApplicationInfo() { AuthCode = "", KeyOperationLogPath = "" },
    ref ret
);
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
        NoticeIgnoreFlag =
            EsunnyTapApi.TAPI_NOTICE_IGNORE_CLOSE | EsunnyTapApi.TAPI_NOTICE_IGNORE_POSITIONPROFIT,
    }
);
if (ret != 0)
{
    Console.WriteLine($"Login failed ret:{ret}");
    return;
}
await Task.Delay(100000);
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

    public override void OnAPIReady()
    {
        Console.WriteLine("OnAPIReady");
    }
}
