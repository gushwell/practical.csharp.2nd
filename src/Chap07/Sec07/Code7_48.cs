using System.Runtime.InteropServices;

public static class Code7_48 {
    public static void Run() {
        // Windowsだけで実行するようにしている。
        // ディレクトリを変更すれば、Linux, Macでも動作する
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
            string[] files1 = Directory.GetFiles(@"C:\Program Files\Common Files\System");
            string[] files2 = Directory.GetFiles(@"C:\Program Files (x86)\Common Files\System");
            List<string> allFiles = new List<string>(files1); //- files1を複製してallFilesを作成
            allFiles.AddRange(files2); //- allFilesに、files2の要素を追加
                                       // 連結した結果を表示
            allFiles.ForEach(Console.WriteLine);
        }
    }
}
