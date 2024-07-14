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
            _service.Execute(line);
        }
        _service.Terminate();
    }
}
