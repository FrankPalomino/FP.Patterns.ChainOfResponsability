using FP.Patterns.ChainOfResponsability.Exercice1;

var confirm = new ConfirmationHandler();
var pricing = new PricingHandler();
var validation = new ValidationHandler();

confirm.SetNext(pricing);
pricing.SetNext(validation);

ShipmentRequest request = new ShipmentRequest("Peru", "Spain", 150, "Shoes");

confirm.HandleRequest(request);