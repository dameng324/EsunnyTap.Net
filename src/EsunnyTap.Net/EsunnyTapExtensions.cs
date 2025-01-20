using System;
using System.Runtime.InteropServices;

namespace EsunnyTap.Net;

public static class EsunnyTapExtensions
{
    public static unsafe double* AsPointer(this SWIGTYPE_p_double swigPointer)
    {
        return (double*)SWIGTYPE_p_double.getCPtr(swigPointer).Handle;
    }

    public static unsafe ulong* AsPointer(this SWIGTYPE_p_unsigned_long_long swigPointer)
    {
        return (ulong*)SWIGTYPE_p_unsigned_long_long.getCPtr(swigPointer).Handle;
    }

#if NET5_0_OR_GREATER
    public static unsafe Span<double> AsSpan(this SWIGTYPE_p_double swigPointer)
    {
        return new Span<double>(swigPointer.AsPointer(), 20);
    }

    public static unsafe Span<ulong> AsSpan(this SWIGTYPE_p_unsigned_long_long swigPointer)
    {
        return new Span<ulong>(swigPointer.AsPointer(), 20);
    }
#endif
}
