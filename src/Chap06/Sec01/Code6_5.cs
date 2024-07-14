using System.Globalization;

public static class Code6_5 {
    public static void Run() {
        var str1 = "Ｃｏｍｐｕｔｅｒ";
        var str2 = "COMPUTER";
        var cultureInfo = new CultureInfo("ja-JP");
        if (String.Compare(str1, str2, cultureInfo,
                CompareOptions.IgnoreWidth | CompareOptions.IgnoreCase) == 0) {
            Console.WriteLine("一致しています");
        }
    }
}