using System;
using System.Collections.Generic;

using SalesCalculator;

// Code2-19
SalesCounter sales = new SalesCounter("sales.csv");
Dictionary<string, int> amountsPerStore = sales.GetPerStoreSales();
foreach (KeyValuePair<string, int> obj in amountsPerStore) {
    Console.WriteLine($"{obj.Key} {obj.Value}");
}
