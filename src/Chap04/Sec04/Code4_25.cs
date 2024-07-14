using System;
using System.Collections.Generic;

public static class Code4_25 {
    public static void Good() {
        string? message = null;
        message ??= DefaultMessage();
        Console.WriteLine(message);
    }

    private static object? GetMessage(object code) {
        return null;
    }

    private static string DefaultMessage() {
        return "Default Message";
    }

    public static void Other() {
        string? message = null;
        if (message is null)
            message = DefaultMessage();
    }
}
