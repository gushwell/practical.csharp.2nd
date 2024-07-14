var fi = new FileInfo("./Example/Greeting.txt");
DateTime lastWriteTime = fi.LastWriteTime;
Console.WriteLine($"LastWriteTime:{lastWriteTime}");
