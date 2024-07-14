using System.IO;
using System.Text;
using System.Diagnostics;

public class Code10_34 {
    public static void Run() {
        Setup();
        DirectoryInfo di = Directory.CreateDirectory("./Example/temp");
        Verify();
    }

    static void Setup() {
        if (Directory.Exists("./Example/temp"))
            Directory.Delete("./Example/temp", recursive: true);
    }

    static void Verify() {
        Debug.Assert(Directory.Exists("./Example/temp"));
    }


}