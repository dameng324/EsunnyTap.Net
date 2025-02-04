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

public class TapAPIAccountRentInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountRentInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountRentInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIAccountRentInfo obj) {
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

  ~TapAPIAccountRentInfo() {
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
          EsunnyTapApiPINVOKE.delete_TapAPIAccountRentInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSource {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_MatchSource_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_MatchSource_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public char FeeMode {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_FeeMode_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_FeeMode_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenTurnover {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_OpenTurnover_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_OpenTurnover_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosedTurnover {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_ClosedTurnover_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_ClosedTurnover_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseNewTurnover {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_CloseNewTurnover_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_CloseNewTurnover_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenVolume {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_OpenVolume_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_OpenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosedVolume {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_ClosedVolume_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_ClosedVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseNewVolume {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_CloseNewVolume_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_CloseNewVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char MarginMode {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_MarginMode_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_MarginMode_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyTInitMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyTInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyTInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellTInitMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellTInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellTInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyBInitMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyBInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyBInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellBInitMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellBInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellBInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyLInitMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyLInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyLInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellLInitMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellLInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellLInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyMInitMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyMInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyMInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellMInitMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellMInitMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellMInitMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyTMaintMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyTMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyTMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellTMaintMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellTMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellTMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyBMaintMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyBMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyBMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellBMaintMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellBMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellBMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyLMaintMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyLMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyLMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellLMaintMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellLMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellLMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double BuyMMaintMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyMMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_BuyMMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellMMaintMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellMMaintMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIAccountRentInfo_SellMMaintMargin_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountRentInfo() : this(EsunnyTapApiPINVOKE.new_TapAPIAccountRentInfo__SWIG_0(), true) {
  }

  public TapAPIAccountRentInfo(TapAPIAccountRentInfo other) : this(EsunnyTapApiPINVOKE.new_TapAPIAccountRentInfo__SWIG_1(TapAPIAccountRentInfo.getCPtr(other)), true) {
    if (EsunnyTapApiPINVOKE.SWIGPendingException.Pending) throw EsunnyTapApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
