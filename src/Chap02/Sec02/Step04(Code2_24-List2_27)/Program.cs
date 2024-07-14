// Code2-25, Code2-26
using System;

using SalesCalculator;

var sales = new SalesCounter("sales.csv");
var amountsPerStore = sales.GetPerStoreSales();
foreach (var obj in amountsPerStore) {
    Console.WriteLine($"{obj.Key} {obj.Value}");
}

