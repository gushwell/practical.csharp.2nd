using System;
using System.Collections.Generic;

public static class Code4_27 {
    public static void Good() {
        var id = 123;
        var product = GetProduct(id);
        var name = product?.Name ?? DefaultName;
        Console.WriteLine(name);
    }

    public static void Bad() {
        var id = 123;
        var product = GetProduct(id);
        var name = (product is null) ? DefaultName : product.Name;
        Console.WriteLine(name);
    }


    static readonly string DefaultName = "…";


    static Product GetProduct(int id) {
        return new Product();
    }

    public class Product {
        public string Name { get; init; } = null!;
    }


}
