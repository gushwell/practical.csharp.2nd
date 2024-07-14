using System;
using System.Collections.Generic;

public static class Code4_36 {
    public static void Run() {
        var str = "1234";
        if (int.TryParse(str, out var height)) {
            // 変換に成功したときの処理、heightには変換された値が入っている
        } else {
            // 変換に失敗したときの処理
        }
    }

    static void Bad() {
        var str = "1234";
        try {
            int height = int.Parse(str);   //- 変換に失敗すると、例外が発生する
            // 変換に成功したときの処理
        } catch (ArgumentNullException ex) {
   　       //…
        } catch (FormatException ex) {
   　       //…
        }
    }

    static void Other() {
        // 文字列に数値文字列が入っていることが保証されている。
        var str = "1234";
        int height = int.Parse(str);
    }
}
