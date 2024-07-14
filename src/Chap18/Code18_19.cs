namespace Code18_19;

public class Order {
    public List<OrderItem> OrderItems { get; set; }
    public Order() {
        OrderItems = new List<OrderItem>();
    }
   　//…
}

// 以下は単にビルドエラーにならないためのコード。

public class OrderItem { }
