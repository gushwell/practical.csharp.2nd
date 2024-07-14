var line = Console.ReadLine();
if (int.TryParse(line, out var num)) {
    Console.WriteLine("{0:#,#}", num);
} else {
    Console.WriteLine("整数文字列でありません");
}
