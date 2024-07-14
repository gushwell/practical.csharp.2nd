var fi = new FileInfo("./Example/Greeting.txt");
if (fi.Length == 0)
    fi.Delete();

// íËã`ÇæÇØÇ≈é¿çsÇÕÇµÇ»Ç¢
static void Bad() {
    var fi = new FileInfo("./Example/Greeting.txt");
    if (fi.Length == 0)
        File.Delete("./Example/Greeting.txt");
}
