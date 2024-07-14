using System.Diagnostics;
using System.IO;
using System.Text;

public class Code10_38 {
    public static void Run() {
        Setup();
        var di = new DirectoryInfo("./Example/temp");
        // DirectoryInfoオブジェクトdiは生成済み
        di.Delete(recursive: true);
        Verify();
    }

    static void Setup() {
        Util.CopyDirectory("./org/Example/", "./Example", true);
    }

    static void Verify() {
        Debug.Assert(!Directory.Exists("./Example/temp"));
    }
}