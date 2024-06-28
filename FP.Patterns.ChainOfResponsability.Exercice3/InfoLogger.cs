namespace FP.Patterns.ChainOfResponsability.Exercice3
{
    public class InfoLogger : Logger
    {
        public override void ShowLog(string type, string log)
        {
            if (type.Equals("Info"))
            {
                Console.WriteLine($"Info log: {log}");
            }
            else
            {
                _next.ShowLog(type, log);
            }
        }
    }
}
