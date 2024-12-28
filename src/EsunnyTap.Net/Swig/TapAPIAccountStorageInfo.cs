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

public class TapAPIAccountStorageInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountStorageInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountStorageInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIAccountStorageInfo obj) {
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

  ~TapAPIAccountStorageInfo() {
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
          EsunnyTapApiPINVOKE.delete_TapAPIAccountStorageInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountStorageInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIAccountStorageInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountStorageInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIAccountStorageInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountStorageInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIAccountStorageInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountStorageInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIAccountStorageInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public double StorageQty {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountStorageInfo_StorageQty_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountStorageInfo_StorageQty_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountStorageInfo() : this(EsunnyTapApiPINVOKE.new_TapAPIAccountStorageInfo(), true) {
  }

}

}
