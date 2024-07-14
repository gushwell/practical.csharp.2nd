using System;
using System.Collections.Generic;

public static class Code4_34 {
    public static void Run() {
        var a = 10;
        var b = 20;
        (b, a) = (a, b);
        Console.WriteLine($"{a} {b}");
    }

    static void Bad() {
        var a = 10;
        var b = 20;
        var temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"{a} {b}");
    }
}
