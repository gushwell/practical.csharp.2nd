using System.Text.RegularExpressions;

namespace TextFileProcessor;

public class ToHankakuProcessor : TextProcessor {

    private static Dictionary<char, char> _dictionary =
        new Dictionary<char, char>() {
            {'０','0'},{'１','1'},{'２','2'},{'３','3'},{'４','4'},
            {'５','5'},{'６','6'},{'７','7'},{'８','8'},{'９','9'}
        };

    // 本文では扱っていない Regexクラスの Replaceオーバーロードメソッドを利用している。
    // ラムダ式で、変換ルールを指定できる。
    protected override void Execute(string line) {
        var s = Regex.Replace(line, "[０-９]", c => _dictionary[c.Value[0]].ToString());
        Console.WriteLine(s);
    }
}

