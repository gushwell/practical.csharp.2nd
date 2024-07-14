var service = new LineCounterService();
var processor = new TextFileProcessor(service);
processor.Run(args[0]);
