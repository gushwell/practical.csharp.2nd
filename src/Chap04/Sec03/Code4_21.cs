using System;
using System.Collections.Generic;

public static class Code4_21 {
    public static void Good() {
        var items = new List<string> {
            "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
            "Canberra", "Hong Kong",
        };
        var line = "";
        foreach (var item in items) {
            if (line.Length + item.Length > 40)
                break;      //- lineが十分な長さに達したのでループを終わらせる
            line += item;
            // … この後も朱織が続く
        }
        Console.WriteLine(line);
    }

    public static void Bad() {
        var items = new List<string> {
            "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
            "Canberra", "Hong Kong",
        };
        var line = "";
        foreach (var item in items) {
            if (line.Length + item.Length <= 40) {
                line += item;
                // … この後も朱織が続く
            }
        }
        Console.WriteLine(line);
    }

    public static void Bad2() {
        var items = new List<string> {
            "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin",
            "Canberra", "Hong Kong",
        };
        var line = "";
        var isContinue = true;  //- 一時変数を導入
        for (int i = 0; i < items.Count && isContinue; i++) {
            var item = items[i];
            if (line.Length + item.Length > 40)
                isContinue = false;
            else
                line += item;
        }
        Console.WriteLine(line);
    }
}
