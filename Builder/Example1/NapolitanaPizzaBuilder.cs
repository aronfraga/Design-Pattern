namespace Builder; 

public class NapolitanaPizzaBuilder : PizzaBuilder {
    
    public override void buildMasa() {
        pizza.SetMasa("sueva");
        Console.WriteLine("BuildMasa: suave");
    }

    public override void buildSalsa() {
        pizza.SetMasa("dulce");
        Console.WriteLine("BuildSalsa: dulce");
    }

    public override void buildRelleno() {
        pizza.SetMasa("chorizo");
        Console.WriteLine("BuildRelleno: chorizo");
    }
    
}