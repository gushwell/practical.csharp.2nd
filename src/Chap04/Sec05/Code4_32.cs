using System;
using System.Collections.Generic;

public static class Code4_32 {
    public static void Run() {
        var direction = Direction.Fore;
        direction |= Direction.Left;
        if (direction.HasFlag(Direction.Left)) {
            Console.WriteLine("左に進めます");
        }
        if (direction.HasFlag(Direction.Fore)) {
            Console.WriteLine("前に進めます");
        }
        if (direction == Direction.All) {
            Console.WriteLine("前後左右いずれにも進めます");
        }
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
