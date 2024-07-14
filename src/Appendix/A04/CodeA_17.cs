using System.IO.Compression;

public class ListA_17 {
    public static void Run() {
        var name = "sample.txt";
        var archiveFile = @"./archives/example.zip";
        using var zip = ZipFile.OpenRead(archiveFile);
        // 最初に見つかったファイルを抽出
        var entry = zip.Entries.FirstOrDefault(x => x.Name == name);
        if (entry is not null) {
            var destPath = Path.Combine(@"./temp/", entry.FullName);
            Directory.CreateDirectory(Path.GetDirectoryName(destPath)!);
            entry.ExtractToFile(destPath, overwrite: true);
        }
    }
}
