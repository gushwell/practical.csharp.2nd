double sum = 0.0;
for (int i = 0; i < 10; i++)
    sum += 0.1;
if (sum == 1.0)
    Console.WriteLine("sum == 1.0");
else
    Console.WriteLine("sum != 1.0");


if (Math.Abs(sum - 1.0) < 0.000001)
    Console.WriteLine("1.0だと見なす");

decimal sum2 = 0m;
for (var i = 0; i < 3; i++) {
    sum2 += GetDecimal();
}
Console.WriteLine(sum2 == 1m);


static decimal GetDecimal() {
    return 1m / 3m;
}
