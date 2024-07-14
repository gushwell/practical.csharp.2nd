// Lust 2-26
using System;

using SalesCalculator;

var sales = new SalesCounter("sales.csv");
var amounts = sales.GetPerCategorySales();
foreach (var obj in amounts) {
    Console.WriteLine("{0} {1:#,#}円", obj.Key, obj.Value);
}
