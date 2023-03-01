using System.Collections;

namespace Patterns.Command; 

public class SuperTarea : ITareaProducto {

    private List<ITareaProducto> lista = new List<ITareaProducto>();

    public void agrearTarea(ITareaProducto tarea) {
        lista.Add(tarea);
        Console.WriteLine("Tarea agregada");
    }
    
    public void ejecutar(Producto producto) {
        
        lista.ForEach(tarea => tarea.ejecutar(producto));
    }
}