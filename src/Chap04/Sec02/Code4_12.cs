using System;
using System.Collections.Generic;

public static class Code4_12 {
    public static void Good() {
        var list = new List<int> { 10, 20, 30, 40 };
        var key = 40;
        var num = list.Contains(key) ? 1 : 0;
        Console.WriteLine(num);
    }
    public static void Bad() {
        var list = new List<int> { 10, 20, 30, 40 };
        var key = 40;
        int num;
        if (list.Contains(key))
            num = 1;
        else
            num = 0;
        Console.WriteLine(num);

    }


}
