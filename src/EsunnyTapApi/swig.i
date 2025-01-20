/* File : swig.i */

%module(directors="1") EsunnyTapApi
%{ 
    #include "include/TapAPICommDef.h"
    #include "include/TapAPIError.h"
    #include "include/TapQuoteAPIDataType.h"
    #include "include/TapQuoteAPI.h"
    #include "include/TapTradeAPIDataType.h"
    #include "include/TapTradeAPI.h"
%}
/* turn on director wrapping Callback */
%feature("director") ITapQuoteAPINotify;
%feature("director") ITapTradeAPINotify;

%include <typemaps.i>
%apply unsigned int *INOUT { unsigned int *sessionID };
%apply int *INOUT { int &iResult };

%copyctor;

%include "include/TapAPICommDef.h"
%include "include/TapAPIError.h"
%include "include/TapQuoteAPIDataType.h"
%include "include/TapQuoteAPI.h"
%include "include/TapTradeAPIDataType.h"
%include "include/TapTradeAPI.h"