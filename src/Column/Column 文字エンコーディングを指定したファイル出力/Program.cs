using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

var filePath = @"./Greeting.txt";
var sjis = Encoding.GetEncoding("shift_jis");
using (var writer = new StreamWriter(filePath, append: false, encoding: sjis)) {
    writer.WriteLine("色はにほへど　散りぬるを");
}
