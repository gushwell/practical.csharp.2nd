// これは入力ファイルとして利用

using System;
using System.Collections.Generic;

public static class List4_26_Sample {
    public static Product? Run() {
        Sale? sale = GetSale();
        return sale?.Product;
    }
    static Sale? GetSale() {
        return null;
    }

    private static Product? Other() {
        Sale? sale = GetSale();
        if (sale is null)
            return null;
        else
            return sale.Product;
    }


    private static Product? Bad() {
        Sale? sale = GetSale();
        return sale is null ? null : sale.Product;

    }

    public class Sale {
        // 店舗名   
        public string ShopName { get; set; } = string.Empty;

        // 売上高   
        public int Amount { get; set; }

        public Product Product { get; set; } = null!;
    }

    public class Product {
        public string Name { get; init; } = null!;
    }


}
