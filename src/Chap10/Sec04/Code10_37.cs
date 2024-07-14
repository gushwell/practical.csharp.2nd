using System.IO;
using System.Text;
using System.Diagnostics;

public class Code10_37 {
    public static void Run() {
        Setup();
        Directory.Delete("./Example/temp", recursive: true);
        Verify();
    }

    static void Setup() {
        if (!Directory.Exists("./Example/temp")) {
            Directory.CreateDirectory("./Example/temp");
            Directory.CreateDirectory("./Example/temp/sub1");
        }
    }
    static void Verify() {
        Debug.Assert(!Directory.Exists("./Example/temp"));
    }
}