using System.IO;
using System.Text;
using System.Diagnostics;

public class Code10_36 {
    public static void Run() {
        Setup();
        Directory.Delete("./Example/temp");
        Verify();
    }

    static void Setup() {
        if (!Directory.Exists("./Example/temp"))
            Directory.CreateDirectory("./Example/temp");
    }

    static void Verify() {
        Debug.Assert(!Directory.Exists("./Example/temp"));
    }
}