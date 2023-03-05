
using Prototype;
using Prototype.Example2;

Console.WriteLine("=============EXAMPLE 1===============");

Enemigo enemigoBase = new Enemigo("imagen1.png", 50, 50, 100);

Console.WriteLine(enemigoBase);

Enemigo enemigo1 = new Enemigo(enemigoBase);
enemigo1.setPosX(100);
enemigo1.setPosY(100);
enemigo1.setCantidadVida(80);

Console.WriteLine(enemigo1);

Enemigo enemigo2 = new Enemigo(enemigo1);
enemigo1.setPosX(200);
enemigo1.setPosY(200);

Console.WriteLine(enemigo2);

Enemigo enemigoBase2 = new Enemigo("imagen2.png", 0, 200, 75);

Enemigo enemigo3 = enemigoBase.clone();
Enemigo enemigo4 = enemigoBase.clone();
Enemigo enemigo5 = enemigoBase.clone();

enemigo3.setPosX(50);
enemigo3.setPosY(200);

enemigo4.setPosX(330);
enemigo4.setPosY(260);

enemigo5.setPosX(130);
enemigo5.setPosY(160);

Console.WriteLine(enemigo3);
Console.WriteLine(enemigo4);
Console.WriteLine(enemigo5);

Console.WriteLine("=============EXAMPLE 2===============");

CuentaAhorro cuentaAhorro = new CuentaAhorro();
cuentaAhorro.setMonto(200);

CuentaAhorro cuentaAhorro2 = new CuentaAhorro();
CuentaAhorro cuentaClonada = (CuentaAhorro) cuentaAhorro.clonar(); //casteo

Console.WriteLine(cuentaAhorro);
Console.WriteLine(cuentaAhorro2);
Console.WriteLine(cuentaClonada);

