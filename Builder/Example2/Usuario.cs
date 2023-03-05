namespace Builder.Example2; 

public class Usuario {

    private string nombre;
    private string apellido;
    private string edad;
    private string email;
    private string telefono;
    private string direccion;

    /*public Usuario(string nombre, string apellido, string email, string telefono, string direccion) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.email = email;
        this.telefono = telefono;
        this.direccion = direccion;
    }*/

    private Usuario(string nombre, string apellido) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.email = "";
        this.telefono = "";
        this.direccion = "";
    }
    //se pone make por convencion 
    public static Usuario make(string nombre, string apellido) {
        return new Usuario(nombre, apellido);
    }
    
    public Usuario setEdad(string edad) {
        this.edad = edad;
        return this;
    }

    public Usuario setEmail(string email) {
        this.email = email;
        return this;
    }
    
    public Usuario setTelefono(string telefono) {
        this.telefono = telefono;
        return this;
    }
    
    public Usuario setDireccion(string direccion) {
        this.direccion = direccion;
        return this;
    }

    public Usuario build() {
        return this;
    }

    public string toString() {
        return $"{nombre} {apellido} {edad} {email} {telefono} {direccion}";
    }
    
}