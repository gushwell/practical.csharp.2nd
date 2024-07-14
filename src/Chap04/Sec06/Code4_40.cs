using System;
using System.IO;
using System.Collections.Generic;


public class Code4_40 {

    public static void Run() {
        var filePath = "./Sample.txt";
        using var stream = new StreamReader(filePath);

        var texts = stream.ReadToEnd();
        // ここで、読み取ったデータの処理
    } //- streamは、スコープを抜ける時に破棄される

    public static void NotRecommended() {
        var filePath = "./Sample.txt";
        var stream = new StreamReader(filePath);
        try {
            string texts = stream.ReadToEnd();
            // ここで、読み取ったデータの処理
        } finally {
            stream.Dispose();  //- 最後にDisposeを呼び出し、後処理をする
        }
    }
}
