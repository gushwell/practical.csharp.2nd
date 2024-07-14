{
    // 100ヤードをフィートに変換する
    var from = new YardConverter();
    var to = new FeetConverter();
    var converter = new DistanceConverter(from, to);
    var result = converter.Convert(100);
    Console.WriteLine(result);
} 
{
    // 20フィートをインチに変換する
    var from = new FeetConverter();
    var to = new InchConverter();
    var converter = new DistanceConverter(from, to);
    var result = converter.Convert(20);
    Console.WriteLine(result);
}
