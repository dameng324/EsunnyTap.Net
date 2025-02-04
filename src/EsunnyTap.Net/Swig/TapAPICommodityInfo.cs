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

public class TapAPICommodityInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPICommodityInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPICommodityInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPICommodityInfo obj) {
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

  ~TapAPICommodityInfo() {
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
          EsunnyTapApiPINVOKE.delete_TapAPICommodityInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string ExchangeNo {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityName {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityName_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityName_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityEngName {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityEngName_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityEngName_get(swigCPtr);
      return ret;
    } 
  }

  public string RelateExchangeNo {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char RelateCommodityType {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateCommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateCommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string RelateCommodityNo {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateCommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateCommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string RelateExchangeNo2 {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateExchangeNo2_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateExchangeNo2_get(swigCPtr);
      return ret;
    } 
  }

  public char RelateCommodityType2 {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateCommodityType2_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateCommodityType2_get(swigCPtr);
      return ret;
    } 
  }

  public string RelateCommodityNo2 {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateCommodityNo2_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_RelateCommodityNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeCurrency {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_TradeCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_TradeCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public string SettleCurrency {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_SettleCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_SettleCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public double ContractSize {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_ContractSize_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_ContractSize_get(swigCPtr);
      return ret;
    } 
  }

  public char MarginCalculateMode {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_MarginCalculateMode_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_MarginCalculateMode_get(swigCPtr);
      return ret;
    } 
  }

  public char OptionMarginCalculateMode {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_OptionMarginCalculateMode_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_OptionMarginCalculateMode_get(swigCPtr);
      return ret;
    } 
  }

  public char OpenCloseMode {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_OpenCloseMode_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_OpenCloseMode_get(swigCPtr);
      return ret;
    } 
  }

  public double StrikePriceTimes {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_StrikePriceTimes_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_StrikePriceTimes_get(swigCPtr);
      return ret;
    } 
  }

  public char IsOnlyQuoteCommodity {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_IsOnlyQuoteCommodity_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_IsOnlyQuoteCommodity_get(swigCPtr);
      return ret;
    } 
  }

  public double CommodityTickSize {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityTickSize_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityTickSize_get(swigCPtr);
      return ret;
    } 
  }

  public int CommodityDenominator {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityDenominator_set(swigCPtr, value);
    } 
    get {
      int ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityDenominator_get(swigCPtr);
      return ret;
    } 
  }

  public char CmbDirect {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_CmbDirect_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_CmbDirect_get(swigCPtr);
      return ret;
    } 
  }

  public int OnlyCanCloseDays {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_OnlyCanCloseDays_set(swigCPtr, value);
    } 
    get {
      int ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_OnlyCanCloseDays_get(swigCPtr);
      return ret;
    } 
  }

  public char DeliveryMode {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_DeliveryMode_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_DeliveryMode_get(swigCPtr);
      return ret;
    } 
  }

  public int DeliveryDays {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_DeliveryDays_set(swigCPtr, value);
    } 
    get {
      int ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_DeliveryDays_get(swigCPtr);
      return ret;
    } 
  }

  public string AddOneTime {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_AddOneTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_AddOneTime_get(swigCPtr);
      return ret;
    } 
  }

  public int CommodityTimeZone {
    set {
      EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityTimeZone_set(swigCPtr, value);
    } 
    get {
      int ret = EsunnyTapApiPINVOKE.TapAPICommodityInfo_CommodityTimeZone_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPICommodityInfo() : this(EsunnyTapApiPINVOKE.new_TapAPICommodityInfo__SWIG_0(), true) {
  }

  public TapAPICommodityInfo(TapAPICommodityInfo other) : this(EsunnyTapApiPINVOKE.new_TapAPICommodityInfo__SWIG_1(TapAPICommodityInfo.getCPtr(other)), true) {
    if (EsunnyTapApiPINVOKE.SWIGPendingException.Pending) throw EsunnyTapApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
