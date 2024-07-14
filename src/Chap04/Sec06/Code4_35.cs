using System;
using System.Collections.Generic;

public static class Code4_35 {
    // Windowsの場合
    public static void Run() {
        var path = @".\Example\Greeting.txt";
    }

    // マルチプラットフォーム（Linux, Mac, Windows）の場合
    public static void Other() {
        var path = "./Example/Greeting.txt";
    }

    public static void Bad() {
        var path = ".\\Example\\Greeting.txt";
    }
}
