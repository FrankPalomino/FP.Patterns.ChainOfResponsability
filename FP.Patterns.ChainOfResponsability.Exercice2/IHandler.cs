namespace FP.Patterns.ChainOfResponsability.Exercice2
{
    public interface IHandler
    {
        void Handler(Ticket ticket);
        void SetNext(IHandler next);
    }
}
