namespace Ch0404;

public class Sale {
    // 店舗名   
    public string ShopName { get; set; } = string.Empty;

    // 売上高   
    public int Amount { get; set; }

    public Product Product { get; set; } = null!;
}
