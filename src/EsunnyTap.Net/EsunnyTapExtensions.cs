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
}
