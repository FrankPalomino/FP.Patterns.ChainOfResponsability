namespace FP.Patterns.ChainOfResponsability.Exercice1
{
    public interface IHandler
    {
        void HandleRequest(ShipmentRequest request);
        void SetNext(IHandler handler);
    }
}
