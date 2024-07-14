using System;

public static class Code4_11 {
    public static void Good() {
        Console.Write("数値を入力してください =>");
        var line = Console.ReadLine();
        var num = int.Parse(line);
        var text = num switch {
            > 80 => "Aランクです",
            > 60 => "Bランクです",
            > 40 => "Cランクです",
            _ => "Dランクです"   //- 上記以外の場合
        };
        Console.WriteLine(text);
    }
}
