var s1 = Console.ReadLine();
var s2 = Console.ReadLine();
if (string.Compare(s1, s2, ignoreCase: true) == 0)
    Console.WriteLine("等しい");
else
    Console.WriteLine("等しくない");
