# EsunnyTap.Net

[![NuGet](https://img.shields.io/nuget/v/EsunnyTap.Net.svg)](https://www.nuget.org/packages/EsunnyTap.Net)

EsunnyTap.Net是易盛9.0内盘柜台接口的C#封装。它使用Swig技术将易盛的C++接口封装成C#接口。它支持易盛的行情和交易接口。

## 主要功能

- 支持行情和交易接口
- 支持.Net Framework 4.5和.Net Standard 2.0，以及.NET6和.NET8
- 编译时会自动将依赖的dll拷贝到输出目录
- 支持Native AOT编译，避免代码被反编译
- 同时支持Windows和Linux。Mac/IOS/Android由于易盛官方并未发布对应的native dll，所以无法支持

## 常见问题

### API版本号是多少?

TapQuoteApiVersion:Version TapQuoteAPI V9.3.1.4, Date 2018.12.25
TapTradeApiVersion:Version TapTradeAPI V9.0.3.16, Date 2020.08.08

### Dll文件没有自动拷贝到输出目录

默认情况下编译后会拷贝到runtimes/目录下以适应不同的操作系统。如果你的程序只在特定的操作系统下运行，可以在项目csproj配置文件中配置特定的RuntimeIdentifier。
- Windows: `<RuntimeIdentifier>win-x64</RuntimeIdentifier>`
- Linux: `<RuntimeIdentifier>linux-x64</RuntimeIdentifier>`
- 
### 存在中文乱码问题？

在调用所有接口之前尝试使用此接口

```csharp
SwigStringHelper.Register();
```

### 其他问题？

请提交github issue

## 安装

使用 dotnet 命令安装

```bash
dotnet add package EsunnyTap.Net
```

PackageReference

```xml
<PackageReference Include="EsunnyTap.Net" Version="1.1.7" />
```

## 用法

```csharp
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

```

## 打赏

如果这个项目有帮助到你，请随意打赏

![img.png](img.png)

## License

MIT License