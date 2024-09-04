namespace FP.Patterns.ChainOfResponsability.Exercice4
{
    public class EmailLogger : Logger
    {
        private Logger _next;
        public override void LogMessage(string message, string level)
        {
            if ("Warning".Equals(level))
            {
                Console.WriteLine($"Sending an email: {message}");
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
