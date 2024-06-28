namespace FP.Patterns.ChainOfResponsability.Exercice3
{
    public abstract class Logger
    {
        public Logger _next;

        public void SetNext(Logger logger)
        {
            _next = logger;
        }

        public abstract void ShowLog(string type, string log);
    }
}
