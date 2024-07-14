if (args.Length == 0)
    return;
var dir = args[0];
DisplayLargeFile(dir, 1 * 1024L * 1024L);

static void DisplayLargeFile(string dir, long size) {
    var files = Directory
        .EnumerateFiles(dir, "*.*", SearchOption.AllDirectories)
        .Where(file => FileSize(file) >= size);
    foreach (var file in files)
        Console.WriteLine(file);
}

static long FileSize(string file) {
    var fi = new FileInfo(file);
    return fi.Length;
}