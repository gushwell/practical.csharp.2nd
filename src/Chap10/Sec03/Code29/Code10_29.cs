var finfo = new FileInfo("./Example/Greeting.txt");
DateTime creationTime = finfo.CreationTime;
Console.WriteLine($"CreationTime:{creationTime}");
