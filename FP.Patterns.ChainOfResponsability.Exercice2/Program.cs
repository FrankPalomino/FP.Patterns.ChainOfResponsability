using FP.Patterns.ChainOfResponsability.Exercice2;

IHandler easyLow = new EasyLowHandler();
IHandler harderLow = new HardLowHandler();
IHandler easyHight = new EasyHightHandler();
IHandler hardHight = new HardHightHandler();

easyLow.SetNext(harderLow);
harderLow.SetNext(easyHight);
easyHight.SetNext(hardHight);

Ticket ticket1 = new Ticket("123", "Easy Low ticket", "Low", "Easy");
Ticket ticket2 = new Ticket("123", "Hard Low ticket", "Low", "Hard");
Ticket ticket3 = new Ticket("123", "Easy Hight ticket", "Hight", "Easy");
Ticket ticket4 = new Ticket("123", "Hard Hight ticket", "Hight", "Hard");

easyLow.Handler(ticket1);
easyLow.Handler(ticket2);
easyLow.Handler(ticket3);
easyLow.Handler(ticket4);
