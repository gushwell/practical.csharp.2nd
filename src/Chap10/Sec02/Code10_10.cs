using System.IO;
using System.Text;

public class Code10_10 {
    public static void Run() {
        var filePath = "./Example/いろは歌.txt";
        using (var writer = new StreamWriter(filePath)) {
            writer.WriteLine("色はにほへど　散りぬるを");
            writer.WriteLine("我が世たれぞ　常ならむ");
            writer.WriteLine("有為の奥山　今日越えて");
            writer.WriteLine("浅き夢見じ　酔ひもせず");
        }
        Utils.DisplayLines(filePath);
    }
}