namespace SampleApp {
    // 書籍ではコンストラクタを省略しているが実際は必要。

    public class Product {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }

        // コンストラクタ
        public Product(int code, string name, int price) {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }

        // 消費税額を求める
        public int GetTax() {
            return (int)(Price * 0.10);
        }

        // 税込価格を求める
        public int GetPriceIncludingTax() {
            return Price + GetTax();
        }

    }
}
