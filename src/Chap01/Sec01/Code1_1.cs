// Code 1-1

public class Product {
    public int Code { get; private set; }      //- setはprivateに変更
    public string Name { get; private set; }   //- setはprivateに変更
    public int Price { get; private set; }     //- setはprivateに変更

    // コンストラクタ
    public Product(int code, string name, int price) {  //- 追加したコンストラクタ
        this.Code = code;
        this.Name = name;
        this.Price = price;
    }

    // 消費税率は10%
    private readonly double _taxRate = 0.1;

    // 消費税額を求める
    public int GetTax() {
        return (int)(Price * _taxRate);
    }

    // 税込価格を求める
    public int GetPriceIncludingTax() {
        return Price + GetTax();
    }
}