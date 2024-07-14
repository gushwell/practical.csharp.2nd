using System;
using System.Collections.Generic;

public static class Code4_22 {
    public static void Good() {
        Console.WriteLine(GetGreaterThan1000());
    }

    static int GetGreaterThan1000() {
        var numbers = new int[] { 123, 98, 4653, 1234, 54, 9854 };
        foreach (var n in numbers) {
            if (n > 1000) {
                return n;
            }
        }
        return -1;
    }
}
