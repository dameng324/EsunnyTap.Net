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

public class TapAPITradeLoginRspInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPITradeLoginRspInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeLoginRspInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPITradeLoginRspInfo obj) {
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

  ~TapAPITradeLoginRspInfo() {
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
          EsunnyTapApiPINVOKE.delete_TapAPITradeLoginRspInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string UserNo {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_UserNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_UserNo_get(swigCPtr);
      return ret;
    } 
  }

  public int UserType {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_UserType_set(swigCPtr, value);
    } 
    get {
      int ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_UserType_get(swigCPtr);
      return ret;
    } 
  }

  public string UserName {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_UserName_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_UserName_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteTempPassword {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_QuoteTempPassword_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_QuoteTempPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string ReservedInfo {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_ReservedInfo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_ReservedInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginIP {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginIP_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginIP_get(swigCPtr);
      return ret;
    } 
  }

  public uint LastLoginPort {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginPort_set(swigCPtr, value);
    } 
    get {
      uint ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginPort_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginInfo {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginInfo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLoginTime {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastLoginTime_get(swigCPtr);
      return ret;
    } 
  }

  public string LastLogoutTime {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastLogoutTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastLogoutTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LastSettleTime {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastSettleTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_LastSettleTime_get(swigCPtr);
      return ret;
    } 
  }

  public string StartTime {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_StartTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_StartTime_get(swigCPtr);
      return ret;
    } 
  }

  public string InitTime {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_InitTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_InitTime_get(swigCPtr);
      return ret;
    } 
  }

  public char AuthType {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_AuthType_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_AuthType_get(swigCPtr);
      return ret;
    } 
  }

  public string AuthDate {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_AuthDate_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_AuthDate_get(swigCPtr);
      return ret;
    } 
  }

  public ulong UdpCertCode {
    set {
      EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_UdpCertCode_set(swigCPtr, value);
    } 
    get {
      ulong ret = EsunnyTapApiPINVOKE.TapAPITradeLoginRspInfo_UdpCertCode_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPITradeLoginRspInfo() : this(EsunnyTapApiPINVOKE.new_TapAPITradeLoginRspInfo(), true) {
  }

}

}
