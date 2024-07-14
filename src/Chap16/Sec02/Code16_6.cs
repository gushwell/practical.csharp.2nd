public class GenericSample<T> where T : IComparable<T> {
    // …
    private bool _first = true;
    private T? _prev;
    private readonly List<T> _items = new();

    public void Execute(T value) {
        if (_first || value.CompareTo(_prev) > 0) { // 比較できる
            _items.Add(value);
            _prev = value;
            _first = false;
        }
        // …
    }
    // …
}
