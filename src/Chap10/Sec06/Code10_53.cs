using System.IO;
using System.Text;

public class Code10_53 {
    public static void Run() {
        // UserProfileフォルダーの取得
        var userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        Console.WriteLine($"UserProfile {userProfile}");

        // デスクトップフォルダーの取得
        var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        Console.WriteLine($"DesktopPath {desktopPath}");
        // マイドキュメントフォルダーの取得
        var myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Console.WriteLine($"MyDocumentsPath {myDocumentsPath}");
        // プログラムファイルフォルダーの取得
        var programFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        Console.WriteLine($"ProgramFilesPath {programFilesPath}");
        // システムフォルダーの取得
        var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
        Console.WriteLine($"SystemPath {systemPath}");
    }

}