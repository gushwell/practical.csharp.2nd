using System.IO;
using System.Text;

public class Code10_14 {
    public static void Run() {
        // 何回実行しても同じ結果になるように、ファイルを保存しておく
        var filePath = "./Example/いろは歌.txt";
        var saveFilePath = "./Example/いろは歌save.txt";
        File.Copy(filePath, saveFilePath, overwrite: true);

        InsertLines();
        Utils.DisplayLines(filePath);

        // 保存したファイルから元に戻す
        File.Copy(saveFilePath, filePath, overwrite: true);
    }

    // これが本来の書籍に掲載したコード
    public static void InsertLines() {
        var filePath = "./Example/いろは歌.txt";

        using var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
        using var reader = new StreamReader(stream);
        using var writer = new StreamWriter(stream);

        string texts = reader.ReadToEnd();
        stream.Position = 0;
        writer.WriteLine("挿入する新しい行1");
        writer.WriteLine("挿入する新しい行2");
        writer.Write(texts);

    }

    public static void Bad() {
        var filePath = "./Example/いろは歌.txt";

        string texts = "";
        // ファイルをすべて読み込む
        using (var reader = new StreamReader(filePath)) {
            texts = reader.ReadToEnd();
        }
        // 一旦クローズ

        // 再度ファイルを開き出力処理をする
        using (var writer = new StreamWriter(filePath)) {
            writer.WriteLine("挿入する新しい行1");
            writer.WriteLine("挿入する新しい行2");
            writer.Write(texts);
        }
    }

}