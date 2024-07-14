using System.IO.Compression;

public class ListA_16 {
    public static void Run() {
        var archiveFile = @"./archives/example.zip";
        using ZipArchive zip = ZipFile.OpenRead(archiveFile);
        var entries = zip.Entries;
        foreach (var entry in entries) {
            Console.WriteLine(entry.FullName);
        }
    }
}
