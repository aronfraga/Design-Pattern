using Builder;
using Builder.Example2;

Console.WriteLine("==================EXAMPLE 1===================");

Cocina cocina = new Cocina();

PizzaBuilder napolitanaPizzaBuilder = new NapolitanaPizzaBuilder();
PizzaBuilder jamonYQuesoPizzaBuilder = new JamonYQuesoPizzaBuilder();

cocina.setPizzaBuilder(jamonYQuesoPizzaBuilder);
cocina.construirPizza();

Console.WriteLine("=====================================");

cocina.setPizzaBuilder(napolitanaPizzaBuilder);
cocina.construirPizza();

Console.WriteLine("==================EXAMPLE 2===================");

Usuario usuario1 = Usuario.make("Maxi", "Principe")
                          .setEdad("22")
                          .setEmail("test@test.com")
                          .setTelefono("555-5555")
                          .setDireccion("Calle Falsa 123")
                          .build();

Usuario usuario2 = Usuario.make("Aaron", "Fraga")
                          .build();
                          
Console.WriteLine(usuario1.toString());
Console.WriteLine(usuario2.toString());

