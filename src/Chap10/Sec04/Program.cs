using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 存在確認
Console.WriteLine("List10.32");
Code10_32.Run();

Console.WriteLine("List10.33");
Code10_33.Run();

Console.WriteLine("List10.34");
Code10_34.Run();

Console.WriteLine("List10.35");
Code10_35.Run();
Code10_35.CreateSubDirectory();

Console.WriteLine("List10.36");
Code10_36.Run();

Console.WriteLine("List10.37");
Code10_37.Run();

Console.WriteLine("List10.38");
Code10_38.Run();

Console.WriteLine("List10.39");
Code10_39.Run();

Console.WriteLine("List10.40");
Code10_40.Run();

Console.WriteLine("List10.41");
Code10_41.Run();

Console.WriteLine("List10.42");
Code10_42.Run();

Util.CopyDirectory("./org/Example/", "./Example", true);


Console.WriteLine("List10.43");
Code10_43.Run();
Console.WriteLine("List10.43(2)");
Code10_43.Run2();
Console.WriteLine("List10.43(3)");
Code10_43.Run3();

Console.WriteLine("List10.44");
Code10_44.Run();
Console.WriteLine("List10.44(2)");
Code10_44.Run2();

Console.WriteLine("List10.45");
Code10_45.Run();

Console.WriteLine("List10.46");
Code10_46.Run();


class Util {
    public static void CopyDirectory(string sourceDir, string destinationDir, bool recursive) {
        if (Directory.Exists(destinationDir))
            Directory.Delete(destinationDir, recursive: true);

        // Get information about the source directory
        var dir = new DirectoryInfo(sourceDir);

        // Check if the source directory exists
        if (!dir.Exists)
            throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

        // Cache directories before we start copying
        DirectoryInfo[] dirs = dir.GetDirectories();

        // Create the destination directory
        Directory.CreateDirectory(destinationDir);

        // Get the files in the source directory and copy to the destination directory
        foreach (FileInfo file in dir.GetFiles()) {
            string targetFilePath = Path.Combine(destinationDir, file.Name);
            file.CopyTo(targetFilePath);
        }

        // If recursive and copying subdirectories, recursively call this method
        if (recursive) {
            foreach (DirectoryInfo subDir in dirs) {
                string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                CopyDirectory(subDir.FullName, newDestinationDir, true);
            }
        }
    }

}

// static void SetupFiles() {
//     CopyDirectory("./org/Example/", "./Example", true);
//     if (Directory.Exists("./Example/save"))
//         Directory.Delete("./Example/save", recursive: true);
//     // ./Example/temp を ./Example/save　に移動
//     if (Directory.Exists("./MyWork/"))
//         Directory.Delete("./MyWork", recursive: true);
//     if (File.Exists("./Example/work01.txt")) {
//         File.Delete("./Example/work01.txt");
//     }
//     if (File.Exists("./Example/work02.txt")) {
//         File.Delete("./Example/work02.txt");
//     }

// }

