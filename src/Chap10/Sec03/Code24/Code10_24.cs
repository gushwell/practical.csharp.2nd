// サンプルメソッドの連続実行可能にするため。
File.Delete("./Example/newfile.txt");
if (!File.Exists("./Example/oldfile.txt"))
    File.Copy("./Example/org/oldfile.txt", "./Example/oldfile.txt");
Console.ReadLine();

// 実際のコード
var fi = new FileInfo("./Example/oldfile.txt");
fi.MoveTo("./Example/newfile.txt");
