using System.IO;
using System.Text;

// Code10_16 

var fi = new FileInfo("./Example/Greeting.txt");
if (fi.Exists) {
    Console.WriteLine("すでに存在しています。");
}
