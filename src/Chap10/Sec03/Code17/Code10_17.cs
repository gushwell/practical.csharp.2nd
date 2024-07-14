using System.IO;
using System.Text;

// サンプルメソッドの連続実行可能にするため。
if (!File.Exists("./Example/Greeting.txt")) {
    File.Copy("./Example/org/Greeting.txt", "./Example/Greeting.txt");
}
Console.ReadLine();

// Code10_17
File.Delete("./Example/Greeting.txt");
