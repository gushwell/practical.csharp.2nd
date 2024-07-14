public class MyStack<T> {
    private int size = 0;
    private static readonly int MaxSize = 100;
    private readonly T[] items = new T[MaxSize];

    public void Push(T x) => items[size++] = x;

    public T Pop() => items[--size];
}
