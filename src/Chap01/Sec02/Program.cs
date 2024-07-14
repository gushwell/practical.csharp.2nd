DateTime date = new DateTime(2015, 7, 29);
int year = date.Year;
// 10日後を求める
DateTime daysAfter10 = date.AddDays(10);


// 同じように使える

MyClass myClass = new MyClass { X = 1, Y = 2 };
MyStruct myStruct = new MyStruct { X = 1, Y = 2 };

Console.WriteLine($"X={myClass.X} Y={myClass.Y}");
Console.WriteLine($"X={myStruct.X} Y={myStruct.Y}");
