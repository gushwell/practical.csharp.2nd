using System;
using System.Collections.Generic;

public static class Code4_26 {
    public static Product? Good() {
        Sale? sale = GetSale();
        return sale?.Product;
    }
    static Sale? GetSale() {
        return null;
    }

    public static Product? Other() {
        Sale? sale = GetSale();
        if (sale is null)
            return null;
        else
            return sale.Product;
    }


    public static Product? Bad() {
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
