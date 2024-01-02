namespace FP.Patterns.ChainOfResponsability.Exercice1
{
    public class ValidationHandler : IHandler
    {
        private IHandler _handler;
        public void HandleRequest(ShipmentRequest request)
        {
            if (request.Weight > 0)
            {
                Console.WriteLine("Shipment Validated!");
                _handler?.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("Weight incorrect");
            }
        }

        public void SetNext(IHandler handler)
        {
            _handler = handler;
        }
    }
}
