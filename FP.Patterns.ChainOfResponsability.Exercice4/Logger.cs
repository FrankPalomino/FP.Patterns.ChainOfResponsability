namespace FP.Patterns.ChainOfResponsability.Exercice4
{
    public abstract class Logger
    {
        public abstract void LogMessage(string message, string level);

        public abstract void SetNext(Logger logger);
    }
}
