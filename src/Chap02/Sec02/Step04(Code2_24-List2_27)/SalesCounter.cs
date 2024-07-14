// Code 2-27
using System.IO;
using System.Collections.Generic;

namespace SalesCalculator;

// 売り上げ集計クラス
public class SalesCounter {
    private readonly IEnumerable<Sale> _sales;

    // コンストラクタ
    public SalesCounter(string filePath) {
        _sales = ReadSales(filePath);
    }

    // 売り上げデータを読み込み、Saleオブジェクトのリストを返す
    private static IEnumerable<Sale> ReadSales(string filePath) {
        var sales = new List<Sale>();
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines) {
            var items = line.Split(',');
            var sale = new Sale {
                ShopName = items[0],
                ProductCategory = items[1],
                Amount = int.Parse(items[2])
            };
            sales.Add(sale);
        }
        return sales;
    }


    // Code 2-24
    // 店舗別売り上げを求める
    public IDictionary<string, int> GetPerStoreSales() {
        var dict = new Dictionary<string, int>();
        foreach (var sale in _sales) {
            if (dict.ContainsKey(sale.ShopName))
                dict[sale.ShopName] += sale.Amount;
            else
                dict[sale.ShopName] = sale.Amount;
        }
        return dict;
    }
}
