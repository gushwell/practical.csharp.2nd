// サンプルメソッドの連続実行可能にするため。
File.Delete("./Example/dest/Greeting.txt");
File.Delete("./Example/src/Greeting.txt");
File.Copy("./Example/Greeting.txt", "./Example/src/Greeting.txt");
Console.ReadLine();

// ここからが実際のコード
var fi = new FileInfo("./Example/src/Greeting.txt");
fi.MoveTo("./Example/dest/Greeting.txt");
