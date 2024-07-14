
namespace Code18_5;

public class Code18_5 {
    static List<Sale> ReadSales(string filePath) {
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
}

class Sale {
    public string ShopName { get; set; } = string.Empty;
    public string ProductCategory { get; set; } = string.Empty;
    public int Amount { get; set; }

}