namespace Patterns.Memento; 

public class Usuario {

    private string nombre;
    private int edad;

    public Usuario(string nombre, int edad) {
        this.setNombre(nombre);
        this.setEdad(edad);
    }

    public Usuario getMemento() {
        return new Usuario(this.getNombre(), this.getEdad());
    }

    public void recuperarMemento(Usuario usuario) {
        this.setNombre(usuario.getNombre());
        this.setEdad(usuario.getEdad());
    }

    public string getNombre() {
        return this.nombre;
    }
    
    public void setNombre(string nombre) {
        this.nombre = nombre;
    }
    
    public int getEdad() {
        return this.edad;
    }
    
    public void setEdad(int edad) {
        this.edad = edad;
    }
    
}