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

public class TapAPIPositionInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIPositionInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIPositionInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIPositionInfo obj) {
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

  ~TapAPIPositionInfo() {
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
          EsunnyTapApiPINVOKE.delete_TapAPIPositionInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ParentAccountNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_ParentAccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_ParentAccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNoRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_ExchangeNoRef_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_ExchangeNoRef_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityTypeRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityTypeRef_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityTypeRef_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNoRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityNoRef_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityNoRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNoRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_ContractNoRef_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_ContractNoRef_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePriceRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_StrikePriceRef_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_StrikePriceRef_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlagRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_CallOrPutFlagRef_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_CallOrPutFlagRef_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderExchangeNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_OrderExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_OrderExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderCommodityType {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_OrderCommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_OrderCommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderCommodityNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_OrderCommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_OrderCommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSource {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchSource_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchSource_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeInForce {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_TimeInForce_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_TimeInForce_get(swigCPtr);
      return ret;
    } 
  }

  public string ExpireTime {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_ExpireTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_ExpireTime_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSide {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchSide_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchSide_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string PositionNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_PositionNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_PositionNo_get(swigCPtr);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeMatchNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_ExchangeMatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_ExchangeMatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchDate {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchDate_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchDate_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchTime {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchTime_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperMatchTime {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperMatchTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperMatchTime_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperSettleNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperSettleNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperSettleNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperUserNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_TradeNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_TradeNo_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionPrice {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_PositionPrice_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_PositionPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint PositionQty {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_PositionQty_set(swigCPtr, value);
    } 
    get {
      uint ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_PositionQty_get(swigCPtr);
      return ret;
    } 
  }

  public char IsBackInput {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_IsBackInput_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_IsBackInput_get(swigCPtr);
      return ret;
    } 
  }

  public char IsAddOne {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_IsAddOne_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_IsAddOne_get(swigCPtr);
      return ret;
    } 
  }

  public uint MatchStreamID {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public uint PositionStreamId {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_PositionStreamId_set(swigCPtr, value);
    } 
    get {
      uint ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_PositionStreamId_get(swigCPtr);
      return ret;
    } 
  }

  public char OpenCloseMode {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_OpenCloseMode_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_OpenCloseMode_get(swigCPtr);
      return ret;
    } 
  }

  public double ContractSize {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_ContractSize_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_ContractSize_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrencyGroup {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrency {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_CommodityCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlePrice {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_PreSettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_PreSettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlePrice {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_SettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_SettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double Turnover {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_Turnover_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_Turnover_get(swigCPtr);
      return ret;
    } 
  }

  public char AccountMarginMode {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_AccountMarginMode_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_AccountMarginMode_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountMarginParam {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_AccountMarginParam_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_AccountMarginParam_get(swigCPtr);
      return ret;
    } 
  }

  public char UpperMarginMode {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperMarginMode_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperMarginMode_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperMarginParam {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperMarginParam_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperMarginParam_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountInitialMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_AccountInitialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_AccountInitialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountMaintenanceMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_AccountMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_AccountMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperInitialMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperInitialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperInitialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperMaintenanceMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_UpperMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double LMEPositionProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_LMEPositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_LMEPositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double OptionMarketValue {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_OptionMarketValue_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_OptionMarketValue_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchCmbNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchCmbNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_MatchCmbNo_get(swigCPtr);
      return ret;
    } 
  }

  public char IsHistory {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_IsHistory_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_IsHistory_get(swigCPtr);
      return ret;
    } 
  }

  public double FloatingPL {
    set {
      EsunnyTapApiPINVOKE.TapAPIPositionInfo_FloatingPL_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIPositionInfo_FloatingPL_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIPositionInfo() : this(EsunnyTapApiPINVOKE.new_TapAPIPositionInfo(), true) {
  }

}

}
