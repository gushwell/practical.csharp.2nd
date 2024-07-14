using System.Runtime.CompilerServices;

public class Code16_4 {
    public static void Run() {
        var abbrs = new Abbreviations();
        var names = new[] { "WHO", "FIFA", "IMF", };
        foreach (var name in names) {
            var fullname = abbrs[name];  //- インデクサを利用
            if (fullname == null)
                Console.WriteLine("{0}は見つかりません", name);
            else
                Console.WriteLine("{0}={1}", name, fullname);
        }
    }
}

