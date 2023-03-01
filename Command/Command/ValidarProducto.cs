namespace Patterns.Command; 

public class ValidarProducto : ITareaProducto {
    public void ejecutar(Producto producto) {
        Console.WriteLine("[ ------------------------- Tarea validar producto ----------------------- ]");
        if (producto.getPrecio() < 100) {
            Console.WriteLine("Producto valido para el envio");
        }
        else {
            Console.WriteLine("Producto no valido para el envio");
        }

    }
}