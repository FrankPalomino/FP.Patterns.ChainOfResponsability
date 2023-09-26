namespace FP.Patterns.ChainOfResponsability.Exercice0
{
    public class HighHandler : BaseHandler
    {
        public override void Handle(double amount)
        {
            if (amount >= 50000)
            {
                System.Console.WriteLine("HighHandler: I can handle this request");
            }
            else
            {
                System.Console.WriteLine("HighHandler: I can't handle this request");
                base.Handle(amount);
            }
        }
    }
}
