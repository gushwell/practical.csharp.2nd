using System.IO.Compression;

public class ListA_18 {
    public static void Run() {
        var sourceFolder = @"./temp/zip";
        var archiveFile = @"./archives/newArchive.zip";
        ZipFile.CreateFromDirectory(sourceFolder, archiveFile, CompressionLevel.Fastest, includeBaseDirectory: true);
    }
}
