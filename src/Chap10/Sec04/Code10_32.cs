using System.IO;
using System.Text;

public class Code10_32 {
    public static void Run() {
        if (Directory.Exists("./Example")) {
            Console.WriteLine("存在しています");
        } else {
            Console.WriteLine("存在していません");
        }
    }
}
