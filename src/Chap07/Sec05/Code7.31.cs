public static class Code7_31 {
    public static void Run() {
        List<int> numbers = new List<int> { 9, 7, -5, -4, 2, 5, 4, 0, -4, 8, -1, 0, 4 };
        int index = -1;
        for (int i = 0; i < numbers.Count; i++) {
            if (numbers[i] < 0) {
                index = i;
                break;
            }
        }
        Console.WriteLine(index);
    }
}