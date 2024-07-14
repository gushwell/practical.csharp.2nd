
namespace Code18_20;

public class Order {
    private List<OrderItem> _orderItems = new();
    public IEnumerable<OrderItem> OrderItems => _orderItems;
    public void AddOrderItem(OrderItem item) {
        _orderItems.Add(item);
    }
   　//…
}

// 以下は単にビルドエラーにならないためのコード。

public class OrderItem { }