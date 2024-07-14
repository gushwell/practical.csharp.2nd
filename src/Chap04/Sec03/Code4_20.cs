using System;
using System.Collections.Generic;

public static class Code4_20 {
    public static void Good() {
        Console.WriteLine("空行で入力が終わります");
        bool finish;
        do {
            finish = DoSomething();  //- DoSomethingはユーザーが別途定義したメソッド。最低1回は実行する
        } while (!finish);
    }

    static bool DoSomething() {
        var line = Console.ReadLine();
        var finish = string.IsNullOrEmpty(line);
        Console.WriteLine(line.ToString());
        return finish;
    }

    public static void Other() {
        var finish = false;
        while (!finish) {
            finish = DoSomething();
        }
    }

    public static void Bad() {
        var finish = DoSomething();
        while (!finish) {
            finish = DoSomething();
        }
    }
}
