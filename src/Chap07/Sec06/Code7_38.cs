public static class Code7_38 {
    public static void Run() {
        List<int> numbers = new List<int> { 9, 7, 5, 4, 2, 4, 0, -4, -1, 0, 4 };
        List<int> selected = new List<int>();
        bool found = false;
        for (int i = 0; i < numbers.Count; i++) {
            if (numbers[i] < 0) {
                found = true;
            }
            if (found) {
                selected.Add(numbers[i]);
            }
        }
        selected.ForEach(Console.WriteLine);
    }
}