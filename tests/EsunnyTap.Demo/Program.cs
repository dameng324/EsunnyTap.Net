using System;
using EsunnyTap.Demo;

try{
    var test=new QuoteTests();
    await test.Test();}
catch(Exception e){
    Console.WriteLine(e.Message);
}

try{
    var test=new TradeTests();
    await test.Test();}
catch(Exception e){
    Console.WriteLine(e.Message);
}