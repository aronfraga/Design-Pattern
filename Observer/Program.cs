using Observer;

Sujeto sujeto = new Sujeto();
new EuroEspObservador(sujeto);
new PesoArgObservador(sujeto);
new PesoMexObservador(sujeto);

Console.WriteLine("Si desea cambiar 20 Dolares obtendria:");
sujeto.setEstado(20);
Console.WriteLine("=====================================");

Console.WriteLine("Si desea cambiar 75 Dolares obtendria:");
sujeto.setEstado(75);
Console.WriteLine("=====================================");