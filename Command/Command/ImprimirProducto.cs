namespace Patterns.Command; 

public class ImprimirProducto  : ITareaProducto {
    public void ejecutar(Producto producto) {
        Console.WriteLine("[ ------------------------- Tarea imprimir producto ----------------------- ]");
        Console.WriteLine(producto.getId() + " - " + producto.getNombre() + " - " + producto.getPrecio());
    }
}