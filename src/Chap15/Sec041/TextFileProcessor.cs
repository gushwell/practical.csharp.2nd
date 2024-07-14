public class TextFileProcessor {
    private LineCounterService _service;

    public TextFileProcessor() {
        _service = new LineCounterService();
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