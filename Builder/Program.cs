using Builder;

Cocina cocina = new Cocina();

PizzaBuilder napolitanaPizzaBuilder = new NapolitanaPizzaBuilder();
PizzaBuilder jamonYQuesoPizzaBuilder = new JamonYQuesoPizzaBuilder();

cocina.setPizzaBuilder(jamonYQuesoPizzaBuilder);
cocina.construirPizza();

Console.WriteLine("=====================================");

cocina.setPizzaBuilder(napolitanaPizzaBuilder);
cocina.construirPizza();