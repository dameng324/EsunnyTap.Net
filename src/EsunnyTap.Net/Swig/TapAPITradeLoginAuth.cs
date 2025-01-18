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

public class TapAPITradeLoginAuth : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPITradeLoginAuth(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeLoginAuth obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPITradeLoginAuth obj) {
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

  ~TapAPITradeLoginAuth() {
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
          EsunnyTapApiPINVOKE.delete_TapAPITradeLoginAuth(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserNo {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AuthCode {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_AuthCode_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_AuthCode_get(swigCPtr);
      return ret;
    } 
  }

  public string AppID {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_AppID_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_AppID_get(swigCPtr);
      return ret;
    } 
  }

  public char ISModifyPassword {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_ISModifyPassword_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_ISModifyPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_Password_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string NewPassword {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_NewPassword_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_NewPassword_get(swigCPtr);
      return ret;
    } 
  }

  public char ISDDA {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_ISDDA_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_ISDDA_get(swigCPtr);
      return ret;
    } 
  }

  public string DDASerialNo {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_DDASerialNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_DDASerialNo_get(swigCPtr);
      return ret;
    } 
  }

  public uint NoticeIgnoreFlag {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_NoticeIgnoreFlag_set(swigCPtr, value);
    } 
    get {
      uint ret = EsunnyTapApiPINVOKE.TapAPITradeLoginAuth_NoticeIgnoreFlag_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPITradeLoginAuth() : this(EsunnyTapApiPINVOKE.new_TapAPITradeLoginAuth__SWIG_0(), true) {
  }

  public TapAPITradeLoginAuth(TapAPITradeLoginAuth other) : this(EsunnyTapApiPINVOKE.new_TapAPITradeLoginAuth__SWIG_1(TapAPITradeLoginAuth.getCPtr(other)), true) {
    if (EsunnyTapApiPINVOKE.SWIGPendingException.Pending) throw EsunnyTapApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
