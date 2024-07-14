using System.Diagnostics;
using System.IO;
using System.Text;

public class Code10_41 {
    public static void Run() {
        Setup();
        Directory.Move("./Example/temp", "./Example/save");
        Verify();
    }

    static void Setup() {
        if (Directory.Exists("./Example/save"))
            Directory.Delete("./Example/save", recursive: true);

        Util.CopyDirectory("./org/Example/", "./Example", true);
    }

    static void Verify() {
        Debug.Assert(Directory.Exists("./Example/save"));
        Debug.Assert(!Directory.Exists("./Example/temp"));
    }


    public static void Bad() {
        Directory.Move("./Example/temp", "save");
    }
}