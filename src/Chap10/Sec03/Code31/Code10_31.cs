var fi = new FileInfo("./Example/Greeting.txt");
if (fi.Length == 0)
    fi.Delete();

// ��`�����Ŏ��s�͂��Ȃ�
static void Bad() {
    var fi = new FileInfo("./Example/Greeting.txt");
    if (fi.Length == 0)
        File.Delete("./Example/Greeting.txt");
}
