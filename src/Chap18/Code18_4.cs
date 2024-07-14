namespace Code18_4;

public class Code18_4 {
    static List<Sale> ReadSales(string filePath) {
        List<Sale> sales;  //- 初期化をしていないので、var sales;とは書けない
        string[] lines;
        string[] items;
        Sale sale;

        sales = new List<Sale>();
        lines = File.ReadAllLines(filePath);
        foreach (string line in lines) {
            items = line.Split(',');
            sale = new Sale {
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