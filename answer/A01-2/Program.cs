
// 1.2.2
MyClass myClass = new MyClass { X = 1, Y = 2 };
MyStruct myStruct = new MyStruct { X = 3, Y = 4 };
PrintObjects(myClass, myStruct);
Console.WriteLine();

// 1.2.3
PrintObjectsTwice(myClass, myStruct);
Console.WriteLine();
Console.WriteLine("MyClass  : ({0},{1})", myClass.X, myClass.Y);
Console.WriteLine("MyStruct : ({0},{1})", myStruct.X, myStruct.Y);

// 1.2.1

static void PrintObjects(MyClass obj1, MyStruct obj2)
{
    Console.WriteLine("MyClass  : ({0},{1})", obj1.X, obj1.Y);
    Console.WriteLine("MyStruct : ({0},{1})", obj2.X, obj2.Y);
}

/* 1.2.4
    myClass変数には、オブジェクトへの参照が格納されている。
    そのため、引数obj1には、MainメソッドのMyClassオブジェクトへの参照が渡ってくるので、
    obj1のプロパティの値を変更すると、変数 myClassが指す、MyClassオブジェクトが変更されることになる。
    一方、obj2には、myStructオブジェクトのコピーが渡ってくるので、
    obj2のプロパティの値を変更しても、myStructオブジェクトには影響しない。
*/


// 1.2.3
//    問題文は、PrintObjects と指定していますが、
//    両方の答えを示すため、PrintObjectsTwice として実装しています。
static void PrintObjectsTwice(MyClass obj1, MyStruct obj2)
{
    obj1.X *= 2;
    obj1.Y *= 2;
    obj2.X *= 2;
    obj2.Y *= 2;
    Console.WriteLine("MyClass  : ({0},{1})", obj1.X, obj1.Y);
    Console.WriteLine("MyStruct : ({0},{1})", obj2.X, obj2.Y);
}


// クラス
class MyClass
{
    public int X { get; set; }
    public int Y { get; set; }
}

// 構造体
struct MyStruct
{
    public int X { get; set; }
    public int Y { get; set; }
}


