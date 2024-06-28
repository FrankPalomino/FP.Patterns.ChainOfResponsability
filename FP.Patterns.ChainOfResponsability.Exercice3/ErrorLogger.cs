namespace FP.Patterns.ChainOfResponsability.Exercice3
{
    public class ErrorLogger : Logger
    {
        public override void ShowLog(string type, string log)
        {
            if (type.Equals("Error"))
            {
                Console.WriteLine($"Error log: {log}");
            }
            else
            {
                _next.ShowLog(type, log);
            }
        }
    }
}
