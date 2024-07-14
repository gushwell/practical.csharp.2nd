using System;
using System.Collections.Generic;

public static class Code4_13 {
    public static void Good() {
        var list = new List<int> { 10, 20, 30, 40 };
        var key = 40;

        // 引数を渡す際にも使える
        DoSomething(list.Contains(key) ? 1 : 0);
    }

    static void DoSomething(int n) {
        Console.WriteLine(n);
    }


}
