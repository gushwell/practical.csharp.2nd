using System.ComponentModel.Design;
using System.IO;
using System.Text;

public class Code10_46 {
    public static void Run() {
        var now = DateTime.Now;
        var di = new DirectoryInfo("./Example");
        FileSystemInfo[] fileSystems = di.GetFileSystemInfos();
        foreach (var item in fileSystems) {
            item.LastWriteTime = now;
        }
        Verify();
    }

    static void Verify() {
        var di = new DirectoryInfo("./Example");
        FileSystemInfo[] fileSystems = di.GetFileSystemInfos();
        foreach (var item in fileSystems) {
            Console.WriteLine($"{item.Name} : {item.LastWriteTime}");
        }
    }
}