using System.IO;
using System.Text;

// �T���v�����\�b�h�̘A�����s�\�ɂ��邽�߁B
if (!File.Exists("./Example/Greeting.txt")) {
    File.Copy("./Example/org/Greeting.txt", "./Example/Greeting.txt");
}
Console.ReadLine();

// Code10_17
File.Delete("./Example/Greeting.txt");
