namespace Patterns.Command; 

public class GestorTareas {
    public void ejecutar(ITareaProducto tarea, Producto producto) {
        tarea.ejecutar(producto);
    }
}