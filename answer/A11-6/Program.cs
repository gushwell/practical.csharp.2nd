using System.Text.RegularExpressions;

var text = "しるし しんぶんし きたのたき 12321 きもの madam いろしろい トマト ヨクナクヨ";
var pattern = @"\b(\w)(\w)\w\2\1\b";

var matches = Regex.Matches(text, pattern);
foreach (Match m in matches) {
    Console.WriteLine("'{0}'", m.Value);
}


// ひらがな、カタカナだけからなる回文の場合
var pattern2 = @"\b([\p{IsHiragana}\p{IsKatakana}])([\p{IsHiragana}\p{IsKatakana}])[\p{IsHiragana}\p{IsKatakana}]\2\1\b";

var matches2 = Regex.Matches(text, pattern2);
foreach (Match m in matches2) {
    Console.WriteLine("'{0}'", m.Value);
}