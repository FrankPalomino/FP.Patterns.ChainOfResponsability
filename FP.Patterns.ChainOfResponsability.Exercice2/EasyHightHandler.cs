namespace FP.Patterns.ChainOfResponsability.Exercice2
{
    public class EasyHightHandler : IHandler
    {
        private IHandler _next;

        public void Handler(Ticket ticket)
        {
            if (ticket.Dificulty.Equals("Easy") && ticket.Priority.Equals("Hight"))
            {
                Console.WriteLine($"The ticket was processing by Easy Hight Agent");
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
