
var student = new Student("井上はるか", new DateOnly(2007, 6, 14));

var clone = student with { };
Console.WriteLine(clone);

var p1 = new Point(100, 50);
var p2 = p1 with { Y = 80 };
Console.WriteLine(p1);
Console.WriteLine(p2);

public record Point(int X, int Y);

record Student(string Name, DateOnly Birthday);
