namespace FP.Patterns.ChainOfResponsability.Exercice1
{
    public class PricingHandler : IHandler
    {
        private IHandler _handler;
        public void HandleRequest(ShipmentRequest request)
        {
            Console.WriteLine("Price Calculated!");
            _handler?.HandleRequest(request);
        }

        public void SetNext(IHandler handler)
        {
            _handler = handler;
        }
    }
}
