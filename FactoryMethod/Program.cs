using Patterns.FactoryMethod;

Console.WriteLine("## Factory Method");

Factura f = FactoryFactura.getFactura("IVA REDUCIDO");
f.setId(1);
f.setImporte(100);
Console.WriteLine(f.Importe());