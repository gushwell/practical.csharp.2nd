// Code 2-23
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
        List<Sale> sales = new List<Sale>();
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines) {
            string[] items = line.Split(',');
            Sale sale = new Sale {
                ShopName = items[0],
                ProductCategory = items[1],
                Amount = int.Parse(items[2])
            };
            sales.Add(sale);
        }
        return sales;
    }

    // 店舗別売り上げを求める
    public IDictionary<string, int> GetPerStoreSales() {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach (Sale sale in _sales) {
            if (dict.ContainsKey(sale.ShopName))
                dict[sale.ShopName] += sale.Amount;
            else
                dict[sale.ShopName] = sale.Amount;
        }
        return dict;
    }
}
