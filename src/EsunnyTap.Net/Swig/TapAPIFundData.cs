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

public class TapAPIFundData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIFundData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIFundData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(TapAPIFundData obj) {
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

  ~TapAPIFundData() {
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
          EsunnyTapApiPINVOKE.delete_TapAPIFundData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string AccountNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFundData_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ParentAccountNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_ParentAccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFundData_ParentAccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyGroupNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_CurrencyGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFundData_CurrencyGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = EsunnyTapApiPINVOKE.TapAPIFundData_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeRate {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_TradeRate_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_TradeRate_get(swigCPtr);
      return ret;
    } 
  }

  public char FutureAlg {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_FutureAlg_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFundData_FutureAlg_get(swigCPtr);
      return ret;
    } 
  }

  public char OptionAlg {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_OptionAlg_set(swigCPtr, value);
    } 
    get {
      char ret = EsunnyTapApiPINVOKE.TapAPIFundData_OptionAlg_get(swigCPtr);
      return ret;
    } 
  }

  public double PreBalance {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PreBalance_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PreBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double PreUnExpProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PreUnExpProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PreUnExpProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreLMEPositionProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PreLMEPositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PreLMEPositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreEquity {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PreEquity_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PreEquity_get(swigCPtr);
      return ret;
    } 
  }

  public double PreAvailable1 {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PreAvailable1_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PreAvailable1_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMarketEquity {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PreMarketEquity_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PreMarketEquity_get(swigCPtr);
      return ret;
    } 
  }

  public double CashInValue {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_CashInValue_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_CashInValue_get(swigCPtr);
      return ret;
    } 
  }

  public double CashOutValue {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_CashOutValue_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_CashOutValue_get(swigCPtr);
      return ret;
    } 
  }

  public double CashAdjustValue {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_CashAdjustValue_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_CashAdjustValue_get(swigCPtr);
      return ret;
    } 
  }

  public double CashPledged {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_CashPledged_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_CashPledged_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenFee {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_FrozenFee_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_FrozenFee_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenDeposit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_FrozenDeposit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_FrozenDeposit_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountFee {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_AccountFee_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_AccountFee_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeFee {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_ExchangeFee_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_ExchangeFee_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountDeliveryFee {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_AccountDeliveryFee_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_AccountDeliveryFee_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumIncome {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PremiumIncome_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PremiumIncome_get(swigCPtr);
      return ret;
    } 
  }

  public double PremiumPay {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PremiumPay_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PremiumPay_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double DeliveryProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_DeliveryProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_DeliveryProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double UnExpProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_UnExpProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_UnExpProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double ExpProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_ExpProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_ExpProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double LmePositionProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_LmePositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_LmePositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double OptionMarketValue {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_OptionMarketValue_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_OptionMarketValue_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountIntialMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_AccountIntialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_AccountIntialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double AccountMaintenanceMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_AccountMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_AccountMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperInitalMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_UpperInitalMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_UpperInitalMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperMaintenanceMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_UpperMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_UpperMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double Discount {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_Discount_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_Discount_get(swigCPtr);
      return ret;
    } 
  }

  public double Balance {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_Balance_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_Balance_get(swigCPtr);
      return ret;
    } 
  }

  public double Equity {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_Equity_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_Equity_get(swigCPtr);
      return ret;
    } 
  }

  public double Available {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_Available_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_Available_get(swigCPtr);
      return ret;
    } 
  }

  public double CanDraw {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_CanDraw_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_CanDraw_get(swigCPtr);
      return ret;
    } 
  }

  public double MarketEquity {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_MarketEquity_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_MarketEquity_get(swigCPtr);
      return ret;
    } 
  }

  public double OriginalCashInOut {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_OriginalCashInOut_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_OriginalCashInOut_get(swigCPtr);
      return ret;
    } 
  }

  public double FloatingPL {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_FloatingPL_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_FloatingPL_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenRiskFundValue {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_FrozenRiskFundValue_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_FrozenRiskFundValue_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosePL {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_ClosePL_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_ClosePL_get(swigCPtr);
      return ret;
    } 
  }

  public double NoCurrencyPledgeValue {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_NoCurrencyPledgeValue_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_NoCurrencyPledgeValue_get(swigCPtr);
      return ret;
    } 
  }

  public double PrePledgeValue {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PrePledgeValue_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PrePledgeValue_get(swigCPtr);
      return ret;
    } 
  }

  public double PledgeIn {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PledgeIn_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PledgeIn_get(swigCPtr);
      return ret;
    } 
  }

  public double PledgeOut {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PledgeOut_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PledgeOut_get(swigCPtr);
      return ret;
    } 
  }

  public double PledgeValue {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_PledgeValue_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_PledgeValue_get(swigCPtr);
      return ret;
    } 
  }

  public double BorrowValue {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_BorrowValue_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_BorrowValue_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialAccountFrozenMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_SpecialAccountFrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_SpecialAccountFrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialAccountMargin {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_SpecialAccountMargin_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_SpecialAccountMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialAccountFrozenFee {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_SpecialAccountFrozenFee_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_SpecialAccountFrozenFee_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialAccountFee {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_SpecialAccountFee_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_SpecialAccountFee_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialFloatProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_SpecialFloatProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_SpecialFloatProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialCloseProfit {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_SpecialCloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_SpecialCloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialFloatPL {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_SpecialFloatPL_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_SpecialFloatPL_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecialClosePL {
    set {
      EsunnyTapApiPINVOKE.TapAPIFundData_SpecialClosePL_set(swigCPtr, value);
    } 
    get {
      double ret = EsunnyTapApiPINVOKE.TapAPIFundData_SpecialClosePL_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIFundData() : this(EsunnyTapApiPINVOKE.new_TapAPIFundData__SWIG_0(), true) {
  }

  public TapAPIFundData(TapAPIFundData other) : this(EsunnyTapApiPINVOKE.new_TapAPIFundData__SWIG_1(TapAPIFundData.getCPtr(other)), true) {
    if (EsunnyTapApiPINVOKE.SWIGPendingException.Pending) throw EsunnyTapApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
