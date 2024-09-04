using FP.Patterns.ChainOfResponsability.Exercice4;

Logger info = new ConsoleLogger();
Logger debug = new FileLogger();
Logger warning = new EmailLogger();
Logger error = new AlertLogger();

info.SetNext(debug);
debug.SetNext(warning);
warning.SetNext(error);

info.LogMessage("Esto es un debug", "Debug");
info.LogMessage("Error grave", "Error");