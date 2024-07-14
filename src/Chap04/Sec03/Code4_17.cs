using System;
using System.Collections.Generic;

public static class Code4_17 {
    public static void Good() {
        var items = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (var i = 0; i < 5; i++) {   //- 先頭の5つを取り出し処理をする
            Console.WriteLine(items[i]);
        }
    }

    public static void Bad() {
        var items = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (var i = 1; i <= 5; i++) {
            Console.WriteLine(items[i - 1]);
        }

    }

    public static void Bad2() {
        var items = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int i = 0;
        while (i < 5) {
            Console.WriteLine(items[i]);
            i++;
        }
    }



}
