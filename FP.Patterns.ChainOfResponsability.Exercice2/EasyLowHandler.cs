namespace FP.Patterns.ChainOfResponsability.Exercice2
{
    public class EasyLowHandler : IHandler
    {
        private IHandler _next;

        public void Handler(Ticket ticket)
        {
            if(ticket.Dificulty.Equals("Easy") && ticket.Priority.Equals("Low"))
            {
                Console.WriteLine($"The ticket was processing by Easy Low Agent");
            }
            else
            {
                _next?.Handler(ticket);
            }
        }

        public void SetNext(IHandler next)
        {
            _next = next;
        }
    }
}
