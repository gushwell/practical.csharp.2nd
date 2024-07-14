var fi = new FileInfo("./Example/Greeting.txt");
fi.LastWriteTime = DateTime.Now;
Console.WriteLine($"LastWriteTime:{fi.LastWriteTime}");
