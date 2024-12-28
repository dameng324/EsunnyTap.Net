//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace EsunnyTap.Net {

public class TapAPISubmitUserLoginInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPISubmitUserLoginInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPISubmitUserLoginInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPISubmitUserLoginInfo obj) {
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

  ~TapAPISubmitUserLoginInfo() {
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
          EsunnyTapApiPINVOKE.delete_TapAPISubmitUserLoginInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserNo {
    set {
      EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string GatherInfo {
    set {
      EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_GatherInfo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_GatherInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientLoginIP {
    set {
      EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginIP_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginIP_get(swigCPtr);
      return ret;
    } 
  }

  public uint ClientLoginPort {
    set {
      EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginPort_set(swigCPtr, value);
    } 
    get {
      uint ret = EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginPort_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientLoginDateTime {
    set {
      EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_ClientLoginDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientAppID {
    set {
      EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_ClientAppID_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_ClientAppID_get(swigCPtr);
      return ret;
    } 
  }

  public uint AuthKeyVersion {
    set {
      EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_AuthKeyVersion_set(swigCPtr, value);
    } 
    get {
      uint ret = EsunnyTapApiPINVOKE.TapAPISubmitUserLoginInfo_AuthKeyVersion_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPISubmitUserLoginInfo() : this(EsunnyTapApiPINVOKE.new_TapAPISubmitUserLoginInfo(), true) {
  }

}

}
