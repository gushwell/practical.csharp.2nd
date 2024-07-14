// Code 15.19
public class WordCounterService : ITextFileService {
    private int _wordCount;

    public void Initialize(string fname) {
        _wordCount = 0;
    }

    public void Execute(string line) {

        // 一つ前が空白かどうか
        bool isPreviousSpace = true;

        foreach (char c in line) {
            bool isSpace = char.IsWhiteSpace(c);
            if (!isSpace && isPreviousSpace) {
                _wordCount++;
            }
            isPreviousSpace = isSpace;
        }
    }

    public void Terminate() {
        Console.WriteLine(_wordCount);
    }
}