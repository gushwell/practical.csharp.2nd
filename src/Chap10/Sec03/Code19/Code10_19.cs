// サンプルメソッドの連続実行可能にするため。
if (File.Exists("./Example/dest/Greeting.txt")) {
    File.Delete("./Example/dest/Greeting.txt");
}
Console.ReadLine();

// Code10_19 
// ここからが実際のコード
File.Copy("./Example/src/Greeting.txt", "./Example/dest/Greeting.txt");



// これは定義のみ
static void Other() {
    File.Copy("./Example/src/Greeting.txt", "./Example/dest/Greeting.txt", overwrite: true);
}

