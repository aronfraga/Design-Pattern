using Patterns;

Console.WriteLine("## Decorator");
IArbolitoNavidad arbolito = new ArbolitoNavidad();
Console.WriteLine("1. " + arbolito.Decorar());
IArbolitoNavidad arbolitoDecorado1 = new Estrallita(arbolito);
IArbolitoNavidad arbolitoDecorado2 = new Guirnaldas(new Estrallita(arbolito));
IArbolitoNavidad arbolitoDecorado3 = new Estrallita(new Guirnaldas(arbolito));
IArbolitoNavidad arbolitoDecorado4 = new Estrallita(new Guirnaldas(new Juguetes(arbolito)));
Console.WriteLine("2. " + arbolitoDecorado1.Decorar());
Console.WriteLine("3. " + arbolitoDecorado2.Decorar());
Console.WriteLine("4. " + arbolitoDecorado3.Decorar());
Console.WriteLine("5. " + arbolitoDecorado4.Decorar());