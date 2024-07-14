public static class Code7_27 {
    public static void Run() {
        List<int> numbers1 = new List<int> { 9, 7, 5, 4, 2, 4, 0, -4, -1, 0, 4 };
        List<int> numbers2 = new List<int> { 9, 7, 5, 4, 2, 4, 0, -4, -1, 0, 4 };
        bool equal = true;
        if (numbers1.Count != numbers2.Count) {
            equal = false;
        } else {
            for (int i = 0; i < numbers1.Count; i++) {
                if (numbers1[i] != numbers2[i]) {
                    equal = false;
                    break;
                }
            }
        }
        Console.WriteLine(equal);
    }

}