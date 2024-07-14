using System;

public static class Code4_7 {
    public static void Good() {
        var age = 1;
        if (age <= 10) {
            Console.WriteLine("10歳以下です");
        }
    }

    public static void Bad() {
        var age = 1;
        if (10 >= age) {
            Console.WriteLine("10歳以下です");
        }

    }

}
