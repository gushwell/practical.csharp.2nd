using System;              //- Consoleクラスを利用するために必要
using System.Diagnostics;  //- Debugクラスを利用するために必要

using SampleApp;

System.Diagnostics.Debug.WriteLine("Entering Programming");
System.Console.WriteLine("Hello World.");
System.Diagnostics.Debug.WriteLine("Exiting Programming");

// リスト1.7
Debug.WriteLine("Entering Programming");
Console.WriteLine("Hello World.");
Debug.WriteLine("Exiting Programming");

var app = new MyApp();
app.Run();

Product karinto = new Product(123, "かりんとう", 180);
Product daifuku = new Product(253, "大福もち", 160);
int karintoTax = karinto.GetTax();
int daifukuTax = daifuku.GetTax();

Console.WriteLine(karintoTax);
Console.WriteLine(daifukuTax);