namespace Patterns.Command; 

public class EnviarProductoPorCorreo : ITareaProducto {
    public void ejecutar(Producto producto) {
        Console.WriteLine("[ ------------------------- Tarea enviar producto ----------------------- ]");
        Console.WriteLine("Producto " + producto.getNombre() + " enviando por correo");
    }
}