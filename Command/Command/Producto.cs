namespace Patterns.Command; 

public class Producto {
    private int id;
    private string nombre;
    private double precio;

    public Producto() {
        
    }

    public Producto(int id, string nombre, double precio) {
        this.id = id;
        this.nombre = nombre;
        this.precio = precio;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getId() {
        return id;
    }
    
    public void setNombre(string nombre) {
        this.nombre = nombre;
    }

    public string getNombre() {
        return nombre;
    }
    
    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public double getPrecio() {
        return precio;
    }

    public override string ToString() {
        return $"Producto [ id= {id} , nombre= {nombre} , precio= {precio}]";
    }
}