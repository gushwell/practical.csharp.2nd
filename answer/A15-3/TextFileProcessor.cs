namespace TextFileProcessing;

// 書籍では触れていないが、TextFileProcessorには、改良の余地がある。
// ここまできた読者は、このTake20Processorを実装すると気が付くはずである。
// Executeメソッドにbool型の戻り値を追加し、trueなら継続、falseなら処理終了の
// 判断をするようにしてある。

// Code 15.18
public class TextFileProcessor {
    private ITextFileService _service;

    // コンストラクタ。ITextFileServiceを引数として受け取る
    public TextFileProcessor(ITextFileService service) {
        _service = service;
    }

    public void Run(string fileName) {
        _service.Initialize(fileName);
        var lines = File.ReadLines(fileName);
        foreach (var line in lines) {
            if (!_service.Execute(line)) {
                break;
            }
        }
        _service.Terminate();
    }
}

