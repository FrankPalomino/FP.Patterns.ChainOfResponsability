namespace FP.Patterns.ChainOfResponsability.Exercice3
{
    public class WarningLogger : Logger
    {
        public override void ShowLog(string type, string log)
        {
            if (type.Equals("Warning"))
            {
                Console.WriteLine($"Warning log: {log}");
            }
            else
            {
                _next.ShowLog(type, log);
            }
        }
    }
}
