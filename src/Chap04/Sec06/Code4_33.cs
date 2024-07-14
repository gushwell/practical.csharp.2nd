using System;
using System.Collections.Generic;

public static class Code4_33 {
    public static void Run() {
        var count = 1;
        count++;
        ++count;
        Console.WriteLine(count);
    }

    public static void Bad() {
        var count = 1;
        count += 1;
        count = count + 1;
        Console.WriteLine(count);
    }
}
