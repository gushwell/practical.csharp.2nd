
using System.Runtime.InteropServices;

public class Code18_14 {
    public static bool LaunchApp(string filePath, string[] arguments,
        string workingDirectory, ProcessWindowStyle windowStyle, bool waitForExit,
        TimeSpan waitTime, int priority) {
        //  …
        return true;
    }
}

// 以下は単にビルドエラーにならないためのコード。

public enum ProcessWindowStyle {
    Normal
}