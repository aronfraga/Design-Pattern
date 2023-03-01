using Patterns.AbstracFactory;

Console.WriteLine("## Abstract Factory");
IAnimalFactory factoryTierraAnimal = FactoryProvider.getFactory("Tierra");
IAnimalFactory factoryMarAnimal = FactoryProvider.getFactory("Mar");
IAnimal Perro = factoryTierraAnimal.crear("Perro");
IAnimal Delfin = factoryMarAnimal.crear("Delfin");

Console.WriteLine("El " + Perro.getAnimal() + " hace " + Perro.hacerSonido());
Console.WriteLine("El " + Delfin.getAnimal() + " hace " + Delfin.hacerSonido());