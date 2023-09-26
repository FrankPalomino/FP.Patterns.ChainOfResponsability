namespace FP.Patterns.ChainOfResponsability.Exercice0
{
    public class BaseHandler : IHandler
    {
        private IHandler _nextHandler;

        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }

        public virtual void Handle(double amount)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(amount);
            }
        }
    }
}
