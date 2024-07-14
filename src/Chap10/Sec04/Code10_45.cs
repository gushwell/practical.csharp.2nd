using System.IO;
using System.Text;

public class Code10_45 {
    public static void Run() {
        var di = new DirectoryInfo("./Example");
        var fileSystems = di.EnumerateFileSystemInfos();
        foreach (var item in fileSystems) {
            if (item.Attributes.HasFlag(FileAttributes.Directory)) {
                Console.WriteLine($"ディレクトリ:{item.Name} {item.CreationTime}");
            } else {
                Console.WriteLine($"ファイル:{item.Name} {item.CreationTime}");
            }
        }
    }
}