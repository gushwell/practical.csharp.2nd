using System.Text;

using (var sr = new StreamReader(args[0], Encoding.UTF8)) {
    int count = 0;
    while (!sr.EndOfStream) {
        string? line = sr.ReadLine();
        count++;
    }
    Console.WriteLine(count);
}
