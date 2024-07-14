using System;
using System.Collections.Generic;

public static class Code4_31 {
    public static void Run() {
        var direction = Direction.Fore;
        Console.WriteLine(direction);

        direction = Direction.Fore | Direction.Right;
        Console.WriteLine(direction);

    }

    [Flags]
    public enum Direction {
        None = 0,
        Fore = 0b0001,
        Back = 0b0010,
        Left = 0b0100,
        Right = 0b1000,
        All = 0b1111,
    }
}
