namespace FP.Patterns.ChainOfResponsability.Exercice1
{
    public class ConfirmationHandler : IHandler
    {
        private IHandler _handler;
        public void HandleRequest(ShipmentRequest request)
        {
            Console.WriteLine("Shipment confirmed!");
            _handler?.HandleRequest(request);
        }

        public void SetNext(IHandler handler)
        {
            _handler = handler;
        }
    }
}
