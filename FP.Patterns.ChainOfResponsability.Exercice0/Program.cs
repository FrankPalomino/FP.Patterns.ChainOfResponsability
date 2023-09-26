using FP.Patterns.ChainOfResponsability.Exercice0;

IHandler lowHandler = new LowHandler();
IHandler mediumHandler = new MediumHandler();
IHandler highHandler = new HighHandler();

lowHandler.SetNext(mediumHandler);
mediumHandler.SetNext(highHandler);

lowHandler.Handle(500);
lowHandler.Handle(5000);
lowHandler.Handle(60000);