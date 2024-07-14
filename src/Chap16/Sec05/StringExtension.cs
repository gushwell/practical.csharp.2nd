namespace Gushwell.Utilities;

public static class StringExtension {
    public static string StringJoin<T>(this IEnumerable<T> items, string separator) {
        var array = items.Select(x => x?.ToString() ?? "").ToArray();
        return string.Join(separator, array);
    }
}
