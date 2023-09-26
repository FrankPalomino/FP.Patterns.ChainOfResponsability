namespace FP.Patterns.ChainOfResponsability.Exercice0
{
    public interface IHandler
    {
        void SetNext(IHandler handler);
        void Handle(double amount);
    }
}
