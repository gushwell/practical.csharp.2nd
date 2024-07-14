
public class Abbreviations {
    private readonly Dictionary<string, string> _dict = [];

    // コンストラクタ
    public Abbreviations() {
        var lines = File.ReadAllLines("./Abbreviations.txt");
        _dict = lines.Select(line => line.Split('='))
                     .ToDictionary(x => x[0], x => x[1]);
    }

    // 要素を追加
    public void Add(string abbr, string japanese) =>
        _dict[abbr] = japanese;

    // 省略語から対応する日本語を取り出す
    public string? Get(string abbr) =>
        _dict.ContainsKey(abbr) ? _dict[abbr] : null;

    // 日本語から対応する省略語を取り出す
    public string? ToAbbreviation(string japanese) =>
        _dict.FirstOrDefault(x => x.Value == japanese).Key;

    // 日本語の部分文字列を引数に与え、それが含まれる要素(Key,Value)をすべて取り出す
    public IEnumerable<(string, string)> FindAll(string substring) {
        foreach (var (key, value) in _dict) {
            if (value.Contains(substring)) {
                yield return (key, value);
            }
        }
    }

    // 8.2.1
    public int Count => _dict.Count;

    // 8.2.2
    public bool Remove(string abb) => _dict.Remove(abb);

    // Dictionary<TKey, TValue>は、
    // IEnumerable<KeyValuePair<TKey, TValue>>を実装しているので
    // _dictを返せば良い
    public IEnumerable<KeyValuePair<string, string>> GetAll() {
        return _dict;
    }
}
