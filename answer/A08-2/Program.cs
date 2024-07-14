var abbrs = new Abbreviations();

// Addメソッドの呼び出し例
abbrs.Add("IOC", "国際オリンピック委員会");
abbrs.Add("NPT", "核拡散防止条約");

// 8.2.3 (Countの呼び出し例)
// 上のAddメソッドで、２つのオブジェクトを追加しているので、読み込んだ単語数+2が、Countの値になる。
var count = abbrs.Count;
Console.WriteLine(abbrs.Count);
Console.WriteLine();

// 8.2.3 (Removeの呼び出し例)
if (abbrs.Remove("NPT")) {
    Console.WriteLine(abbrs.Count);
}

// すでに削除してあるので、falseが返る
if (!abbrs.Remove("NPT")) {
    Console.WriteLine("削除できません");
}
Console.WriteLine();

// 8.2.4
// GetAllメソッドを実装したので、LINQが使える。
// クラスそのものにIEnumerableを実装する方法もある。
var query = abbrs
    .GetAll()
    .Where(x => x.Key.Length == 3);
foreach (var item in query) {
    Console.WriteLine("{0}={1}", item.Key, item.Value);
}