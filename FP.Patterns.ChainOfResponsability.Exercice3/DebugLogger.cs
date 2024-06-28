namespace FP.Patterns.ChainOfResponsability.Exercice3
{
    public class DebugLogger : Logger
    {
        public override void ShowLog(string type, string log)
        {
            if (type.Equals("Debug"))
            {
                Console.WriteLine($"Debug log: {log}");
            }
            else
            {
                _next.ShowLog(type, log);
            }
        }
    }
}
