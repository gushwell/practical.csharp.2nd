using System.IO;
using System.Text;

// サンプルメソッドの連続実行可能にするため。
if (!File.Exists("./Example/Greeting.txt")) {
    File.Copy("./Example/org/Greeting.txt", "./Example/Greeting.txt");
}
Console.ReadLine();

// Code10_18 
var fi = new FileInfo("./Example/Greeting.txt");
fi.Delete();
