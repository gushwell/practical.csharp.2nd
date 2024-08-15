Product karinto = new Product(123, "かりんとう", 180);
Product daifuku = new Product(253, "大福もち", 160);

Console.WriteLine(karinto.Price);
Console.WriteLine(daifuku.Price);


int karintoTax = karinto.GetTax();
int daifukuTax = daifuku.GetTax();

Console.WriteLine(karintoTax);
Console.WriteLine(daifukuTax);

int taxIncluded = karinto.GetPriceIncludingTax();
int daifukuAmount = daifuku.GetPriceIncludingTax();
Console.WriteLine(taxIncluded);
Console.WriteLine(daifukuAmount);

