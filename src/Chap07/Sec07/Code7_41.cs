public static class Code7_41 {
    public static void Run() {
        List<string> words = new List<string> { "Microsoft", "Apple", "Google", "Amazon", "Meta", };
        List<string> lowers = new List<string>();
        foreach (string name in words) {
            lowers.Add(name.ToLower());
        }
        lowers.ForEach(Console.WriteLine);
    }
}