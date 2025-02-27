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

public class TapAPISubmitUserLoginRspInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPISubmitUserLoginRspInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPISubmitUserLoginRspInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPISubmitUserLoginRspInfo obj) {
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

  ~TapAPISubmitUserLoginRspInfo() {
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
          EsunnyTapApiPINVOKE.delete_TapAPISubmitUserLoginRspInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserNo {
    set {
      EsunnyTapApiPINVOKE.TapAPISubmitUserLoginRspInfo_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPISubmitUserLoginRspInfo_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public uint ErrorCode {
    set {
      EsunnyTapApiPINVOKE.TapAPISubmitUserLoginRspInfo_ErrorCode_set(swigCPtr, value);
    } 
    get {
      uint ret = EsunnyTapApiPINVOKE.TapAPISubmitUserLoginRspInfo_ErrorCode_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorText {
    set {
      EsunnyTapApiPINVOKE.TapAPISubmitUserLoginRspInfo_ErrorText_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPISubmitUserLoginRspInfo_ErrorText_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPISubmitUserLoginRspInfo() : this(EsunnyTapApiPINVOKE.new_TapAPISubmitUserLoginRspInfo__SWIG_0(), true) {
  }

  public TapAPISubmitUserLoginRspInfo(TapAPISubmitUserLoginRspInfo other) : this(EsunnyTapApiPINVOKE.new_TapAPISubmitUserLoginRspInfo__SWIG_1(TapAPISubmitUserLoginRspInfo.getCPtr(other)), true) {
    if (EsunnyTapApiPINVOKE.SWIGPendingException.Pending) throw EsunnyTapApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
