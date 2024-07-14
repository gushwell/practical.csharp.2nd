using System;
using System.Collections.Generic;

public static class Code4_23 {
    public static void Good() {
        string? name = null;
        if (name is null)
            Console.WriteLine("nameはnullです");
            
        if (name is not null)
            Console.WriteLine("nameはnullではありません");
    }
}
