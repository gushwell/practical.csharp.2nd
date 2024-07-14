using System;
using System.Collections.Generic;

public static class Code4_14 {
    public static void Good() {
        int num = GetNumber();
        if (Int32.IsEvenInteger(num)) {

        }
    }

    static int GetNumber() {
        var line = Console.ReadLine();

        if (int.TryParse(line, out var num))
            return num;
        return 0;
    }

}
