using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator;
// 売り上げクラス
public class Sale {
    // 店舗名
    public string ShopName { get; init; } = string.Empty;

    // 商品カテゴリ
    public string ProductCategory { get; init; } = string.Empty;

    // 売り上げ高
    public int Amount { get; init; }
}


