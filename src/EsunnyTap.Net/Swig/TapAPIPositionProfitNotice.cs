//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace EsunnyTap.Net {

public class TapAPIPositionProfitNotice : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIPositionProfitNotice(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIPositionProfitNotice obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIPositionProfitNotice obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~TapAPIPositionProfitNotice() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          EsunnyTapApiPINVOKE.delete_TapAPIPositionProfitNotice(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public char IsLast {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionProfitNotice_IsLast_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionProfitNotice_IsLast_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIPositionProfit Data {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionProfitNotice_Data_set(swigCPtr, TapAPIPositionProfit.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = EsunnyTapApiPINVOKE.TapAPIPositionProfitNotice_Data_get(swigCPtr);
      TapAPIPositionProfit ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIPositionProfit(cPtr, false);
      return ret;
    } 
  }

  public TapAPIPositionProfitNotice() : this(EsunnyTapApiPINVOKE.new_TapAPIPositionProfitNotice__SWIG_0(), true) {
  }

  public TapAPIPositionProfitNotice(TapAPIPositionProfitNotice other) : this(EsunnyTapApiPINVOKE.new_TapAPIPositionProfitNotice__SWIG_1(TapAPIPositionProfitNotice.getCPtr(other)), true) {
    if (EsunnyTapApiPINVOKE.SWIGPendingException.Pending) throw EsunnyTapApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
