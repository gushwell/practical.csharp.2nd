using System.Diagnostics;
using System.IO;
using System.Text;

public class Code10_40 {
    public static void Run() {
        Setup();
        var di = new DirectoryInfo("./Example/temp");
        // DirectoryInfoオブジェクトdiは生成済み
        di.MoveTo("./MyWork");
        Verify();
    }

    static void Setup() {
        if (Directory.Exists("./MyWork"))
            Directory.Delete("./MyWork", recursive: true);

        Util.CopyDirectory("./org/Example/", "./Example", true);
    }

    static void Verify() {
        Debug.Assert(Directory.Exists("./MyWork"));
        Debug.Assert(!Directory.Exists("./Example/temp"));
    }
}