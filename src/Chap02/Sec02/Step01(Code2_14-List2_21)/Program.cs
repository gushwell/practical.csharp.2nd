// Code 2-18, 2-19
using System;
using System.IO;
using System.Collections.Generic;

using SalesCalculator;

SalesCounter sales = new SalesCounter(ReadSales("sales.csv"));
Dictionary<string, int> amountsPerStore = sales.GetPerStoreSales();
foreach (KeyValuePair<string, int> obj in amountsPerStore) {
    Console.WriteLine($"{obj.Key} {obj.Value}");
}

// Code 2-15
// 売り上げデータを読み込み、Saleオブジェクトのリストを返す
static List<Sale> ReadSales(string filePath) {
    List<Sale> sales = new List<Sale>();
    string[] lines = File.ReadAllLines(filePath);
    foreach (string line in lines) {
        string[] items = line.Split(',');
        Sale sale = new Sale {    //- オブジェクト初期化子を使ってプロパティを初期化
            ShopName = items[0],
            ProductCategory = items[1],
            Amount = int.Parse(items[2])
        };
        sales.Add(sale);
    }
    return sales;
}

