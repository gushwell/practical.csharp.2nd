
// 1.1.1, 1.1.2
namespace CSharp.Exercises;

public class Product
{
    public int Code { get; private set; }
    public string Name { get; private set; }
    public int Price { get; private set; }

    // コンストラクタ
    public Product(int code, string name, int price)
    {
        this.Code = code;
        this.Name = name;
        this.Price = price;
    }

    // 消費税率は10%
    private readonly double _taxRate = 0.1;  //- 追加したフィールド

    // 消費税額を求める
    public int GetTax()
    {
        return (int)(Price * _taxRate);
    }

    // 税込価格を求める
    public int GetPriceIncludingTax()
    {
        return Price + GetTax();
    }
}

