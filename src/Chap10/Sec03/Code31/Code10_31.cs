var fi = new FileInfo("./Example/Greeting.txt");
if (fi.Length == 0)
    fi.Delete();

// 定義だけで実行はしない
static void Bad() {
    var fi = new FileInfo("./Example/Greeting.txt");
    if (fi.Length == 0)
        File.Delete("./Example/Greeting.txt");
}
