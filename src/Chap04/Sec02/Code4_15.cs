using System;
using System.Collections.Generic;

public static class Code4_15 {
    public static void Good() {
        if (Compare()) {
            Console.WriteLine("等しい");
        }
    }

    static bool Compare() {
        var a = 10;
        var b = 10;
        return a == b;
    }

    public static bool NotRecommended1() {
        var a = 10;
        var b = 10;
        if (a == b)
            return true;
        else
            return false;
    }

    public static bool NotRecommended2() {
        var a = 10;
        var b = 10;
        if (a == b)
            return true;
        return false;
    }

    public static bool NotRecommended3() {
        var a = 10;
        var b = 10;
        var result = a == b;
        return result;
    }

    public static bool NotRecommended4() {
        var a = 10;
        var b = 10;
        bool result = false;
        if (a == b)
            result = true;
        return result;

    }

}
