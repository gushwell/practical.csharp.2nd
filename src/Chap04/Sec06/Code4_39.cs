using System;
using System.IO;
using System.Collections.Generic;


public class Code4_39 {

    public static void Run() {
        var filePath = "./Sample.txt";
        using (var stream = new StreamReader(filePath)) {
            var texts = stream.ReadToEnd();
            // ここで、読み取ったデータの処理
        }
    }

    public static void Bad() {
        var filePath = "./Sample.txt";
        var stream = new StreamReader(filePath);
        var texts = stream.ReadToEnd();
        // ここで、読み取ったデータの処理
    }
}
