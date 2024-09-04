namespace FP.Patterns.ChainOfResponsability.Exercice4
{
    public class FileLogger : Logger
    {
        private Logger _next;
        public override void LogMessage(string message, string level)
        {
            if ("Debug".Equals(level))
            {
                Console.WriteLine($"Writting on file: {message}");
            }
            else
            {
                _next.LogMessage(message, level);
            }
        }

        public override void SetNext(Logger logger)
        {
            _next = logger;
        }
    }
}
