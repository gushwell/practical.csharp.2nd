using System;
using System.Collections.Generic;

public static class Code4_19 {
    public static void Good() {
        var nums = new List<int> { 1, 2, 3, 4, 5 };
        nums.ForEach(n => Console.Write($"[{n}] "));

        // foreach文を使った場合
        foreach (var n in nums)
            Console.Write($"[{n}] ");

        // こんなふうにも書ける
        nums.ForEach(Console.WriteLine);
    }

    public static void Bad() {
        var nums = new List<int> { 1, 2, 3, 4, 5 };
        nums.ForEach(n => {
            //
            // ここに長いコード
            //
        });
    }
}
