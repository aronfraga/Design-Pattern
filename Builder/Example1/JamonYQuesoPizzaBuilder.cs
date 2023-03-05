namespace Builder; 

public class JamonYQuesoPizzaBuilder : PizzaBuilder {
    
    public override void buildMasa() {
        pizza.SetMasa("cocida");
        Console.WriteLine("BuildMasa: cocida");
    }

    public override void buildSalsa() {
        pizza.SetMasa("suave");
        Console.WriteLine("BuildSalsa: suave");
    }

    public override void buildRelleno() {
        pizza.SetMasa("queso");
        Console.WriteLine("BuildRelleno: queso");
    }
    
}