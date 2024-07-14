using System.Globalization;

public static class Code6_3 {
    public static void Run() {
        var str1 = "カステラ";
        var str2 = "かすてら";
        var cultureInfo = new CultureInfo("ja-JP");
        if (String.Compare(str1, str2, cultureInfo, CompareOptions.IgnoreKanaType) == 0) {
            Console.WriteLine("一致しています");
        }
    }
}