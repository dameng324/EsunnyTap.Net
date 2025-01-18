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

public class TapAPIFillInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIFillInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIFillInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIFillInfo obj) {
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

  ~TapAPIFillInfo() {
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
          EsunnyTapApiPINVOKE.delete_TapAPIFillInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ParentAccountNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_ParentAccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_ParentAccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNoRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_ExchangeNoRef_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_ExchangeNoRef_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityTypeRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityTypeRef_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityTypeRef_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNoRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityNoRef_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityNoRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNoRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_ContractNoRef_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_ContractNoRef_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePriceRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_StrikePriceRef_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_StrikePriceRef_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlagRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_CallOrPutFlagRef_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_CallOrPutFlagRef_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderExchangeNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderCommodityType {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderCommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderCommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderCommodityNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderCommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderCommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSource {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchSource_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchSource_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeInForce {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_TimeInForce_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_TimeInForce_get(swigCPtr);
      return ret;
    } 
  }

  public string ExpireTime {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_ExpireTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_ExpireTime_get(swigCPtr);
      return ret;
    } 
  }

  public char IsRiskOrder {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_IsRiskOrder_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_IsRiskOrder_get(swigCPtr);
      return ret;
    } 
  }

  public char MatchSide {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchSide_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchSide_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_PositionEffect_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_PositionEffect_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffectRef {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_PositionEffectRef_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_PositionEffectRef_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char ServerFlag {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_ServerFlag_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_ServerFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderNo_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderLocalNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_OrderLocalNo_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeMatchNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_ExchangeMatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_ExchangeMatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public string MatchDateTime {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperMatchDateTime {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperMatchDateTime_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperMatchDateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperChannelNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperChannelNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperChannelNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperSettleNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperSettleNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperSettleNo_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperUserNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperUserNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperUserNo_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_TradeNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_TradeNo_get(swigCPtr);
      return ret;
    } 
  }

  public double MatchPrice {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchPrice_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint MatchQty {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchQty_set(swigCPtr, value);
    } 
    get {
      uint ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchQty_get(swigCPtr);
      return ret;
    } 
  }

  public char IsBackInput {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_IsBackInput_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_IsBackInput_get(swigCPtr);
      return ret;
    } 
  }

  public char IsDeleted {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_IsDeleted_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_IsDeleted_get(swigCPtr);
      return ret;
    } 
  }

  public char IsAddOne {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_IsAddOne_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_IsAddOne_get(swigCPtr);
      return ret;
    } 
  }

  public uint MatchStreamID {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_MatchStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public uint UpperStreamID {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperStreamID_set(swigCPtr, value);
    } 
    get {
      uint ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperStreamID_get(swigCPtr);
      return ret;
    } 
  }

  public char OpenCloseMode {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_OpenCloseMode_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_OpenCloseMode_get(swigCPtr);
      return ret;
    } 
  }

  public double ContractSize {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_ContractSize_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_ContractSize_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrencyGroup {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityCurrency {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_CommodityCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public char FeeMode {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_FeeMode_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_FeeMode_get(swigCPtr);
      return ret;
    } 
  }

  public double FeeParam {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_FeeParam_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_FeeParam_get(swigCPtr);
      return ret;
    } 
  }

  public string FeeCurrencyGroup {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_FeeCurrencyGroup_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_FeeCurrencyGroup_get(swigCPtr);
      return ret;
    } 
  }

  public string FeeCurrency {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_FeeCurrency_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_FeeCurrency_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlePrice {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_PreSettlePrice_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_PreSettlePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double FeeValue {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_FeeValue_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_FeeValue_get(swigCPtr);
      return ret;
    } 
  }

  public char IsManualFee {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_IsManualFee_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_IsManualFee_get(swigCPtr);
      return ret;
    } 
  }

  public double Turnover {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_Turnover_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_Turnover_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumIncome {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_PremiumIncome_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_PremiumIncome_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumPay {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_PremiumPay_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_PremiumPay_get(swigCPtr);
      return ret;
    } 
  }

  public string OppoMatchNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_OppoMatchNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_OppoMatchNo_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double UnExpProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_UnExpProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_UnExpProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperMatchPrice {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperMatchPrice_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_UpperMatchPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double QuotePrice {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_QuotePrice_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_QuotePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosePL {
    set {
      EsunnyTapApiPINVOKE.TapAPIFillInfo_ClosePL_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFillInfo_ClosePL_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIFillInfo() : this(EsunnyTapApiPINVOKE.new_TapAPIFillInfo__SWIG_0(), true) {
  }

  public TapAPIFillInfo(TapAPIFillInfo other) : this(EsunnyTapApiPINVOKE.new_TapAPIFillInfo__SWIG_1(TapAPIFillInfo.getCPtr(other)), true) {
    if (EsunnyTapApiPINVOKE.SWIGPendingException.Pending) throw EsunnyTapApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
