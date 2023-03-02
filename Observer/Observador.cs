namespace Observer; 

abstract public class Observador {
    
    protected Sujeto sujeto;
    public abstract void actualizar();

}