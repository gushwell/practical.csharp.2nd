using CSharp.Exercises; // 1.1.３、1.1.4

var dorayaki = new Product(98, "どら焼き", 210);
var tax = dorayaki.GetTax();
Console.WriteLine($"{tax}円");
