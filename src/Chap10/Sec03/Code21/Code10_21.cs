// サンプルメソッドの連続実行可能にするため。
File.Delete("./Example/dest/Greeting.txt");
File.Delete("./Example/src/Greeting.txt");
File.Copy("./Example/Greeting.txt", "./Example/src/Greeting.txt");
Console.ReadLine();

// ここからが実際のコード
File.Move("./Example/src/Greeting.txt", "./Example/dest/Greeting.txt");
