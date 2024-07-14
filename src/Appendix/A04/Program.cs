using System.IO.Compression;
if (Directory.Exists(@"./Temp/zip"))
    Directory.Delete(@"./Temp/zip", recursive: true);
if (File.Exists(@"./Archives/newArchive.zip"))
    File.Delete(@"./Archives/newArchive.zip");
if (File.Exists(@"./Temp/sample.txt"))
    File.Delete(@"./Temp/sample.txt");

ListA_15.Run();
ListA_16.Run();
ListA_17.Run();
ListA_18.Run();
