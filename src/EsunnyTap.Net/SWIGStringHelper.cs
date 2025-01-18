using System;
using System.Runtime.InteropServices;
using System.Text;

namespace EsunnyTap.Net;

/// <summary>
///
/// </summary>
public static class SwigStringHelper
{
    private delegate string SwigStringDelegate(IntPtr message);

    private static readonly SwigStringDelegate StringDelegate = CreateString;

    [DllImport("EsunnyTapApi", EntryPoint = "SWIGRegisterStringCallback_EsunnyTapApi")]
    static extern void SWIGRegisterStringCallback_EsunnyTapApi(SwigStringDelegate stringDelegate);
    [DllImport("EsunnyTapApi", EntryPoint="SWIG_csharp_string_size")]
    private static extern int SWIG_csharp_string_size(global::System.IntPtr str);
    // ReSharper disable once InconsistentNaming
#if NETFRAMEWORK
    private static Encoding GB2312 { get; } = Encoding.GetEncoding("GB2312");
#else
    private static Encoding GB2312 { get; } = CodePagesEncodingProvider.Instance.GetEncoding("GB2312")!;
#endif

    static
#if !NET45
    unsafe
#endif
    string CreateString(IntPtr ptr)
    {
        if (ptr == IntPtr.Zero)
            return string.Empty;
        var count = SWIG_csharp_string_size(ptr);
#if NET45
        var buffer = new byte[count];
        Marshal.Copy(ptr, buffer, 0, count);
        return GB2312.GetString(buffer);
#else
        return GB2312.GetString((byte*)ptr, count);
#endif
    }

    public static void Register()
    {
        SWIGRegisterStringCallback_EsunnyTapApi(StringDelegate);
    }
}
