using System.IO.Compression;

public class ListA_15 {
    public static void Run() {
        var archiveFile = @"./archives/example.zip";
        var destinationFolder = @"./temp/zip";
        if (!Directory.Exists(destinationFolder)) {
            ZipFile.ExtractToDirectory(archiveFile, destinationFolder);
        }
    }
}