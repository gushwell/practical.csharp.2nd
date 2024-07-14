using System.IO;
using System.Text;

CurrentDirectorySample();
Directory.SetCurrentDirectory("..");
FileAttributesSample();

static void CurrentDirectorySample() {
    // カレントディレクトリを取得
    var workdir = Directory.GetCurrentDirectory();
    Console.WriteLine(workdir);

    // カレントディレクトリを変更
    Directory.SetCurrentDirectory("./Example");

    // 再度カレントディレクトリを取得し、コンソールに出力して確認
    var newWorkdir = Directory.GetCurrentDirectory();
    Console.WriteLine(newWorkdir);
}

static void FileAttributesSample() {
    var fi = new FileInfo("./Example/Greeting.txt");
    if (fi.Attributes.HasFlag(FileAttributes.ReadOnly)) {
        Console.WriteLine("ReadOnlyファイルです");
    }
    if (fi.Attributes.HasFlag(FileAttributes.System)) {
        Console.WriteLine("Systemファイルです");
    }
}
