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

public class TapAPIUpperChannelInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIUpperChannelInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIUpperChannelInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIUpperChannelInfo obj) {
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

  ~TapAPIUpperChannelInfo() {
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
          EsunnyTapApiPINVOKE.delete_TapAPIUpperChannelInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UpperChannelNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIUpperChannelInfo_UpperChannelNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIUpperChannelInfo_UpperChannelNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperChannelName {
    set {
      EsunnyTapApiPINVOKE.TapAPIUpperChannelInfo_UpperChannelName_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIUpperChannelInfo_UpperChannelName_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIUpperChannelInfo_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIUpperChannelInfo_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperUserNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIUpperChannelInfo_UpperUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIUpperChannelInfo_UpperUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIUpperChannelInfo() : this(EsunnyTapApiPINVOKE.new_TapAPIUpperChannelInfo(), true) {
  }

}

}