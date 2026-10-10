# EsunnyTap.Net

[![NuGet](https://img.shields.io/nuget/v/EsunnyTap.Net.svg)](https://www.nuget.org/packages/EsunnyTap.Net)
[![CI](https://github.com/dameng324/EsunnyTap.Net/actions/workflows/ci.yml/badge.svg)](https://github.com/dameng324/EsunnyTap.Net/actions/workflows/ci.yml)
[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

易盛 TAP 9.0 内盘 API 的 .NET 封装，包含行情和交易接口。项目通过 SWIG 生成 C# 绑定，并随 NuGet 包提供对应平台的原生库。

## 支持范围

| 项目 | 支持范围 |
|---|---|
| .NET 目标框架 | .NET 8、.NET 10、.NET Framework 4.5、.NET Standard 2.0 |
| 原生运行时 | Windows x64（win-x64）、Linux x64（linux-x64） |
| API | 行情、交易 |

.NET 8 和 .NET 10 目标设置了 IsAotCompatible=true。发布应用时，RID 仍须与上表中的原生运行时匹配。

## 安装

~~~bash
dotnet add package EsunnyTap.Net
~~~

## 快速开始

创建交易 API 时需要易盛提供的授权信息。示例中的授权码是占位符，请替换为实际值。

~~~csharp
using System;
using EsunnyTap.Net;

var appInfo = new TapAPIApplicationInfo
{
    AuthCode = "<vendor-issued-auth-code>",
    KeyOperationLogPath = "./",
};

var result = 0;
var api = EsunnyTapApi.CreateTapTradeAPI(appInfo, ref result);
if (result != 0)
{
    throw new InvalidOperationException("CreateTapTradeAPI failed: " + result);
}

// 注册 ITapTradeAPINotify 实现、设置前置地址，再按柜台要求登录。
~~~

行情接口可使用 EsunnyTapApi.CreateTapQuoteAPI 创建。若回调字符串出现中文乱码，可在调用接口前执行 SwigStringHelper.Register()。ErrorCodeMap.GetErrorMsg() 可将接口错误码转换为说明，映射包含 TAP 9 和 V10 错误码。

## API 版本

- 行情：TapQuoteAPI V9.3.1.4，2018-12-25
- 交易：TapTradeAPI V9.0.3.16，2020-08-08

## 原生依赖

NuGet 包包含以下平台目录中的原生库：

- Windows x64：runtimes/win-x64/native
- Linux x64：runtimes/linux-x64/native

发布应用时，将 RuntimeIdentifier 设置为 win-x64 或 linux-x64，以选择目标平台对应的原生依赖。

## 构建

### 环境与本地构建

- 使用 global.json 指定的 .NET SDK，并在仓库根目录执行 dotnet tool restore。
- 使用 .swig-version 指定的 SWIG 版本。
- 原生构建需要 CMake 和对应平台的 C++ 工具链。Windows 使用 Git Bash 和 Visual Studio C++ 工具；Linux 构建可在 Linux 或 WSL2 中运行。

SWIG 生成的 C# 和 C++ 文件不提交到 Git。每次本地构建前，进入 SWIG 项目重新生成：

~~~bash
cd src/EsunnyTapApi
bash ./SwigGenerate.sh
~~~

在 Git Bash 中构建 Windows 原生库：

~~~bash
bash ./win-build.sh
~~~

在 Linux 或 WSL2 中构建 Linux 原生库：

~~~bash
bash ./linux-build.sh
~~~

回到仓库根目录构建解决方案并检查格式：

~~~bash
cd ../..
dotnet build EsunnyTap.Net.slnx --configuration Release
dotnet tool run csharpier check .
~~~

### GitHub Actions

向 main 提交 PR 或推送提交时，ci.yml 调用共享的 build.yml：Ubuntu job 生成 SWIG 绑定并构建 Linux 原生库，Windows job 构建 Windows 原生库、构建解决方案并打包 NuGet。CI 不会发布到 NuGet；生成的 nupkg 会作为保留 30 天的 workflow artifact。

publish.yml 复用同一构建流程。推送 v 前缀版本 tag 会发布 NuGet 包并创建 GitHub Release；也可以在 main 上手动运行该 workflow，并填写不带 v 前缀的版本号。

## 许可证

[MIT License](LICENSE)

问题与建议请提交到 [GitHub Issues](https://github.com/dameng324/EsunnyTap.Net/issues)。
