using System.Text.RegularExpressions;

Console.WriteLine(IsPhoneNumber("090-9111-1234"));
Console.WriteLine(IsPhoneNumber("080-9111-1234"));
Console.WriteLine(IsPhoneNumber("090-9111-1234"));
Console.WriteLine(IsPhoneNumber("060-9111-1234"));
Console.WriteLine(IsPhoneNumber("190-9111-1234"));
Console.WriteLine(IsPhoneNumber("091-9111-1234"));
Console.WriteLine(IsPhoneNumber("090-9111-12341"));
Console.WriteLine(IsPhoneNumber("A090-9111-1234"));
Console.WriteLine(IsPhoneNumber("090-911-1234"));
Console.WriteLine(IsPhoneNumber("090-1911-234"));

static bool IsPhoneNumber(string str) {
    return Regex.IsMatch(str, @"^0[789]0-\d{4}-\d{4}$");
}
