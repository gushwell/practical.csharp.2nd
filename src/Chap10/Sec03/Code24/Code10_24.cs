// �T���v�����\�b�h�̘A�����s�\�ɂ��邽�߁B
File.Delete("./Example/newfile.txt");
if (!File.Exists("./Example/oldfile.txt"))
    File.Copy("./Example/org/oldfile.txt", "./Example/oldfile.txt");
Console.ReadLine();

// ���ۂ̃R�[�h
var fi = new FileInfo("./Example/oldfile.txt");
fi.MoveTo("./Example/newfile.txt");