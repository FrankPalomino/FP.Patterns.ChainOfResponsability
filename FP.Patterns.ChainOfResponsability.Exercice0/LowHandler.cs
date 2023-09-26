namespace FP.Patterns.ChainOfResponsability.Exercice0
{
    public class LowHandler : BaseHandler
    {
        public override void Handle(double amount)
        {
            if (amount <= 1000)
            {
                System.Console.WriteLine("LowHandler: I can handle this request");
            }
            else
            {
                System.Console.WriteLine("LowHandler: I can't handle this request");
                base.Handle(amount);
            }
        }
    }
}
