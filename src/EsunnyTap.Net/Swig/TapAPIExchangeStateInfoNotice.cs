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

public class TapAPIExchangeStateInfoNotice : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIExchangeStateInfoNotice(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIExchangeStateInfoNotice obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIExchangeStateInfoNotice obj) {
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

  ~TapAPIExchangeStateInfoNotice() {
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
          EsunnyTapApiPINVOKE.delete_TapAPIExchangeStateInfoNotice(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public char IsLast {
    set {
      EsunnyTapApiPINVOKE.TapAPIExchangeStateInfoNotice_IsLast_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIExchangeStateInfoNotice_IsLast_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIExchangeStateInfo ExchangeStateInfo {
    set {
      EsunnyTapApiPINVOKE.TapAPIExchangeStateInfoNotice_ExchangeStateInfo_set(swigCPtr, TapAPIExchangeStateInfo.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = EsunnyTapApiPINVOKE.TapAPIExchangeStateInfoNotice_ExchangeStateInfo_get(swigCPtr);
      TapAPIExchangeStateInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPIExchangeStateInfo(cPtr, false);
      return ret;
    } 
  }

  public TapAPIExchangeStateInfoNotice() : this(EsunnyTapApiPINVOKE.new_TapAPIExchangeStateInfoNotice__SWIG_0(), true) {
  }

  public TapAPIExchangeStateInfoNotice(TapAPIExchangeStateInfoNotice other) : this(EsunnyTapApiPINVOKE.new_TapAPIExchangeStateInfoNotice__SWIG_1(TapAPIExchangeStateInfoNotice.getCPtr(other)), true) {
    if (EsunnyTapApiPINVOKE.SWIGPendingException.Pending) throw EsunnyTapApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
