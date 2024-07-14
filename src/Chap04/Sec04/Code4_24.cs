using System;
using System.Collections.Generic;

public static class Code4_24 {
    public static void Good() {
        string code = "12345";
        var message = GetMessage(code) ?? DefaultMessage();
        Console.WriteLine(message);
    }

    private static object? GetMessage(object code) {
        return null;
    }

    private static string DefaultMessage() {
        return "Default Message";
    }

    public static void Other() {
        string code = "12345";
        var message = GetMessage(code);
        if (message is null)
            message = DefaultMessage();
    }
}
