using System.Runtime.InteropServices;
public static class Code7_47 {
    public static void Run() {
        // Windowsだけで実行するようにしている。
        // ディレクトリを変更すれば、Linux, Macでも動作する
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            var files1 = Directory.GetFiles("C:/Program Files/Common Files/System");
            var files2 = Directory.GetFiles("C:/Program Files (x86)/Common Files/System");
            var allFiles = files1.Concat(files2).ToList(); //-file1とfile2を連結
                                                           // 連結した結果を表示
            allFiles.ForEach(Console.WriteLine);
        }
    }
}
