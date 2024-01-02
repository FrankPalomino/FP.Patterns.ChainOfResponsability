namespace FP.Patterns.ChainOfResponsability.Exercice1
{
    public class ShipmentRequest
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public double Weight { get; set; }
        public string Content { get; set; }

        public ShipmentRequest(string origin, string destination, double weight, string content)
        {

            Origin = origin;
            Destination = destination;
            Weight = weight;
            Content = content;
        }
    }
}
