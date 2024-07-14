using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

public class Code10_33 {
    public static void Run() {
        Setup();
        DirectoryInfo di = Directory.CreateDirectory("./Example");
        Verify();
    }

    static void Setup() {
        if (Directory.Exists("./Example"))
            Directory.Delete("./Example", recursive: true);
    }

    static void Verify() {
        Debug.Assert(Directory.Exists("./Example/"));
    }
}