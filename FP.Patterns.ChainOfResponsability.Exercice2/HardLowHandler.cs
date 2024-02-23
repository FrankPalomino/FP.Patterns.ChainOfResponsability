namespace FP.Patterns.ChainOfResponsability.Exercice2
{
    public class HardLowHandler : IHandler
    {
        private IHandler _next;

        public void Handler(Ticket ticket)
        {
            if (ticket.Dificulty.Equals("Hard") && ticket.Priority.Equals("Low"))
            {
                Console.WriteLine($"The ticket was processing by Hard Low Agent");
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
