using System.IO;
using System.Text;
using System.Diagnostics;

public class Code10_35 {
    public static void Run() {
        Setup();
        var di = new DirectoryInfo("./Example");
        di.Create();
        Verify();
    }

    static void Setup() {
        if (Directory.Exists("./Example"))
            Directory.Delete("./Example", recursive: true);
    }

    static void Verify() {
        Debug.Assert(Directory.Exists("./Example"));
    }


    public static void CreateSubDirectory() {
        Setup2();
        // DirectoryInfoオブジェクトdiは生成済み
        DirectoryInfo di = Directory.CreateDirectory("./Example");
        DirectoryInfo sdi = di.CreateSubdirectory("temp");

        Verify2();

    }

    static void Setup2() {
        if (Directory.Exists("./Example"))
            Directory.Delete("./Example", recursive: true);
    }

    static void Verify2() {
        Debug.Assert(Directory.Exists("./Example/temp"));
    }

}