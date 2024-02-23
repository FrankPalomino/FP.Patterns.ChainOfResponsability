namespace FP.Patterns.ChainOfResponsability.Exercice2
{
    public class Ticket
    {
        public string TicketId { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public string Dificulty { get; set; }

        public Ticket(string ticketId, string description, string priority, string dificulty)
        {
            TicketId = ticketId;
            Description = description;
            Priority = priority;
            Dificulty = dificulty;
        }
    }
}
