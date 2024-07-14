using System;
using System.IO;
using System.Collections.Generic;


public class Code4_38 {

    public static void Run() {
        try {
            var lines = File.ReadAllLines("sample.txt");

        } catch (FileNotFoundException ex) {
            // 例外情報を使った何らかの処理
            // …
            throw;
        }
    }
    public static void Bad() {
        try {
            var lines = File.ReadAllLines("sample.txt");
        } catch (FileNotFoundException ex) {
            // 例外情報を使った何らかの処理
            throw ex;   //- このように書いてはいけない
        }
    }
}
