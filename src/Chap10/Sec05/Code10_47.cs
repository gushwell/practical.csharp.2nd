using System.Runtime.InteropServices;

public class Code10_47 {
    public static void Run() {
        // パスを操作するだけなので、Windows以外でも動作する
        var path = @"C:\Program Files\Microsoft Office\Office16/EXCEL.EXE";
        var directoryName = Path.GetDirectoryName(path);
        var fileName = Path.GetFileName(path);
        var extension = Path.GetExtension(path);
        var filenameWithoutExtension = Path.GetFileNameWithoutExtension(path);
        // var pathRoot = Path.GetPathRoot(path);

        Console.WriteLine($"DirectoryName : {directoryName}");
        Console.WriteLine($"FileName : {fileName}");
        Console.WriteLine($"Extension : {extension}");
        Console.WriteLine($"FilenameWithoutExtension : {filenameWithoutExtension}");
        // Console.WriteLine("PathRoot : {0}", pathRoot);    
    }
}

