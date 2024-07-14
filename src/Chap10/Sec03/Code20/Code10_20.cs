// サンプルメソッドの連続実行可能にするため。
if (File.Exists("./Example/dest/Greeting.txt")) {
    File.Delete("./Example/dest/Greeting.txt");
}
Console.ReadLine();

// ここからが実際のコード
var fi = new FileInfo("./Example/src/Greeting.txt");
FileInfo dup = fi.CopyTo("./Example/dest/Greeting.txt", overwrite: true);
