using TextFileProcessor; //- TextProcessorクラスを利用するのに必要

TextProcessor.Run<LineCounterProcessor>(args[0]);

class LineCounterProcessor : TextProcessor {
    private int _count = 0;

    protected override void Initialize(string fname) =>
        _count = 0;

    protected override void Execute(string line) =>
        _count++;

    protected override void Terminate() =>
        Console.WriteLine("{0} 行", _count);
}
