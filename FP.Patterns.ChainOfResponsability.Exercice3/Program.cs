using FP.Patterns.ChainOfResponsability.Exercice3;

DebugLogger debug = new();
InfoLogger info = new();
WarningLogger warning = new();
ErrorLogger error = new();

debug.SetNext(info);
info.SetNext(warning);
warning.SetNext(error);

debug.ShowLog("Info", "there is an error");