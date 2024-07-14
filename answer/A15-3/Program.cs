using TextFileProcessing;

var take20Processor = new Take20Processor();
var tp = new TextFileProcessor(take20Processor);
tp.Run(args[0]);