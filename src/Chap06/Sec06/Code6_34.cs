public static class Code6_34 {
    public static void Run() {
        var target = "Novelist\t=\t谷崎 潤一郎 ";
        var chars = target
            .SkipWhile(c => c != '=')
            .Skip(1)        //- ＝を読み飛ばす
            .Where(c => !char.IsWhiteSpace(c))
            .ToArray();     //- ToArrayでIEnumerable<char>を文字配列に変換
        var str = new string(chars);
        Console.WriteLine(str);
    }
}