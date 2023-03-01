using Patterns.Command;
using Patterns.Command2;

Console.WriteLine("## Command First Example");

/*ITareaProducto t1 = new ValidarProducto();
Producto p = new Producto(2, "TV", 50);
GestorTareas gt = new GestorTareas();
gt.ejecutar(t1, p);*/

SuperTarea st = new SuperTarea();
st.agrearTarea(new ValidarProducto());
st.agrearTarea(new ImprimirProducto());
st.agrearTarea(new EnviarProductoPorCorreo());

Producto p1 = new Producto(3, "Celular", 75);
GestorTareas gt = new GestorTareas();
gt.ejecutar(st, p1);

SuperTarea st2 = new SuperTarea();
st2.agrearTarea(new ValidarProducto());
st2.agrearTarea(new ImprimirProducto());
st2.agrearTarea(new EnviarProductoPorCorreo());

Producto p2 = new Producto(5, "Televisor", 750);
GestorTareas gt2 = new GestorTareas();
gt2.ejecutar(st2, p2);

Console.WriteLine("");
Console.WriteLine("## Command Second Example");

TV tv = new TV();

IComando on = new OnDispositivo(tv);
IComando off = new OffDispositivo(tv);

on.operacion();
off.operacion();