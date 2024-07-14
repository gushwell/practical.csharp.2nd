namespace Gushwell.Utilities;

public static class EnumerableExtension {

    public static string StringJoin<T>(this IEnumerable<T> items, string separator) where T : notnull {
        return string.Join(separator, items);
    }
}
