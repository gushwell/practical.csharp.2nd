using System;

public static class Code4_10 {
    public static void Good() {
        Console.Write("数値を入力してください =>");
        var line = Console.ReadLine();
        int num = int.Parse(line);
        switch (num) {
            case > 80:
                Console.WriteLine("Aランクです");
                break;
            case > 60:
                Console.WriteLine("Bランクです");
                break;
            case > 40:
                Console.WriteLine("Cランクです");
                break;
            default:
                Console.WriteLine("Dランクです");
                break;
        }
    }
}
