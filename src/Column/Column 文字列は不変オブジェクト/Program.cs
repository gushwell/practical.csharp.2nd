//var str = "ajax";
//str[0] = 'A';

var target = "こんにちは山田さん";
var str1 = target.Remove(5, 3);
var str2 = target.Insert(2, "山田さん");

var target2 = "こんにちは";
DoSomething(target2);
Console.WriteLine(target2);

static void DoSomething(string text) {
    text = "";
}