using System.Text;

namespace Gushwell.Utilities;

public static class StringExtensions {
    public static string ToBase64(this string text) {
        var bytes = Encoding.Unicode.GetBytes(text);
        return Convert.ToBase64String(bytes);
    }

    public static string FromBase64(this string text) {
        var bytes = Convert.FromBase64String(text);
        return Encoding.Unicode.GetString(bytes);
    }
}

