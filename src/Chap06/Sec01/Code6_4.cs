using System.Globalization;

public static class Code6_4 {
    public static void Run() {
        var str1 = "JSON";
        var str2 = "ＪＳＯＮ";
        var cultureInfo = new CultureInfo("ja-JP");
        if (String.Compare(str1, str2, cultureInfo, CompareOptions.IgnoreWidth) == 0) {
            Console.WriteLine("一致しています");
        }
    }
}