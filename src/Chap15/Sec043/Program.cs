var service = new WordCounterService();
var processor = new TextFileProcessor(service);
processor.Run(args[0]);
