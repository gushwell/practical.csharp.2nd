using SalesCalculator;

SalesCounter sales = new SalesCounter("sales.csv");
IDictionary<string, int> amountsPerStore = sales.GetPerStoreSales();
foreach (KeyValuePair<string, int> obj in amountsPerStore) {
    Console.WriteLine($"{obj.Key} {obj.Value}");
}
