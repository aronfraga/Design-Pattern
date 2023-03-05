using Strategy;

Transaccion transaccion1 = new Transaccion(new Deposito());
Console.WriteLine(transaccion1.ejecutarTransaccion(100, 200));

Transaccion transaccion2 = new Transaccion(new Retiro());
Console.WriteLine(transaccion2.ejecutarTransaccion(200, 20));

Transaccion transaccion3 = new Transaccion(new MostrarSaldo());
Console.WriteLine(transaccion2.ejecutarTransaccion(200, 0));