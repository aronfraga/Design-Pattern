using Patterns.Facade;

Console.WriteLine("## Facade");

CheckFacade cliente1 = new CheckFacade();
cliente1.buscar("28/02/2023", "30/03/2023", "argentina", "brazil");

CheckFacade cliente2 = new CheckFacade();
cliente1.buscar("10/03/2023", "20/03/2023", "CABA", "Tandil");