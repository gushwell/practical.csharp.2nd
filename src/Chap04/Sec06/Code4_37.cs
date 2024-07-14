using System;
using System.Collections.Generic;

public class Code4_37 {

    // この Session は仮の定義
    private static Dictionary<string, object?> Session { get; set; } = new Dictionary<string, object?> {
        ["MyProduct"] = "Test"
    };

    public static void Run() {

        if (Session["MyProduct"] is Product product) {
            // productが取得できた時の処理
            Console.WriteLine("productが取得できた");
        } else {
            // productが取得できなかった時の処理
            Console.WriteLine("productが取得できなかった");
        }
    }

    public static void Bad() {
        try {
            var product = (Product)Session["MyProduct"]; //- Product型にキャストする
            // Product型にキャストできたときの処理
            Console.WriteLine("productが取得できた");
        } catch (InvalidCastException ex) {
            // Product型にキャストできなかったときの処理
            Console.WriteLine("productが取得できなかった");

        }
    }

    public static void Other() {
        // このSessionは仮の定義
        var Session = new Dictionary<string, object?>();

        var product = Session["MyProduct"] as Product;
        if (product is null) {
            // productが取得できなかった時の処理
            Console.WriteLine("productが取得できなかった");
        } else {
            // productが取得できた時の処理
            Console.WriteLine("productが取得できた");
        }
    }

    public class Product {
        public string Name { get; init; } = null!;
        public int UnitPrice { get; init; }


    }
}
