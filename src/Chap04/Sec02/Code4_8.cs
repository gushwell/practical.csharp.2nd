using System;

public static class Code4_8 {
    public static void Good() {
        var num = 55;
        if (50 <= num && num <= 100) {
            Console.WriteLine("範囲内です");
        }
    }

    public static void NotRecommended() {
        var num = 55;

        if (num >= 50 && num <= 100) {
            Console.WriteLine("範囲内です");
        }

    }

}
