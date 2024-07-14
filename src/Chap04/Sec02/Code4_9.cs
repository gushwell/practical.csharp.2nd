using System;

public static class Code4_9 {
    public static void Good() {
        Console.Write("数値を入力してください =>");
        var line = Console.ReadLine();
        var num = int.Parse(line);
        if (num > 80) {
            Console.WriteLine("Aランクです");
        } else if (num > 60) {
            Console.WriteLine("Bランクです");
        } else if (num > 40) {
            Console.WriteLine("Cランクです");
        } else {
            // マイナス値もDランクとする
            Console.WriteLine("Dランクです");
        }
    }
}
