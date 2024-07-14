using System;
using System.Collections.Generic;

public static class Code4_16 {

    public static void Good(string[] filePathList, string extension) {
        if (filePathList.Length == 0)
            return;
        if (extension != "txt")
            return;
        if (GetOption() == Option.Skip)
            return;
        // 以降本来やりたい処理
    }

    public static void Bad(string[] filePathList, string extension) {
        if (filePathList.Length > 0) {
            if (extension == "txt") {
                if (GetOption() != Option.Skip) {
                    // やりたい処理
                }
            }
        }
    }

    static Option GetOption() {
        return Option.Skip;
    }

    enum Option {
        None,
        Skip,
        Keep,

    }

}
