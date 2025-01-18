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

public class TapAPIAmendOrder : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAmendOrder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAmendOrder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIAmendOrder obj) {
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

  ~TapAPIAmendOrder() {
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
          EsunnyTapApiPINVOKE.delete_TapAPIAmendOrder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TapAPINewOrder ReqData {
    set {
      EsunnyTapApiPINVOKE.TapAPIAmendOrder_ReqData_set(swigCPtr, TapAPINewOrder.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = EsunnyTapApiPINVOKE.TapAPIAmendOrder_ReqData_get(swigCPtr);
      TapAPINewOrder ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPINewOrder(cPtr, false);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      EsunnyTapApiPINVOKE.TapAPIAmendOrder_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIAmendOrder_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIAmendOrder_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIAmendOrder_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAmendOrder() : this(EsunnyTapApiPINVOKE.new_TapAPIAmendOrder__SWIG_0(), true) {
  }

  public TapAPIAmendOrder(TapAPIAmendOrder other) : this(EsunnyTapApiPINVOKE.new_TapAPIAmendOrder__SWIG_1(TapAPIAmendOrder.getCPtr(other)), true) {
    if (EsunnyTapApiPINVOKE.SWIGPendingException.Pending) throw EsunnyTapApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
