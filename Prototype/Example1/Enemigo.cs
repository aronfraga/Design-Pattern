namespace Prototype; 

public class Enemigo {

    private string imagen;
    private int posX;
    private int posY;
    private int cantidadVida;

    public Enemigo(string imagen, int posX, int porY, int cantidadVida) {
        this.imagen = imagen;
        this.posX = posX;
        this.posY = porY;
        this.cantidadVida = cantidadVida;
    }

    public Enemigo(Enemigo enemigo) {
        this.setImagen(enemigo.getImagen());
        this.setPosX(enemigo.getPosX());
        this.setPosY(enemigo.getPosY());
        this.setCantidadVida(enemigo.getCantidadVida());
    }

    public void setImagen(string imagen) {
        this.imagen = imagen;
    }

    public string getImagen() {
        return this.imagen;
    }
    
    public void setPosX(int posx) {
        this.posX = posx;
    }

    public int getPosX() {
        return this.posX;
    }
    
    public void setPosY(int posy) {
        this.posY = posy;
    }

    public int getPosY() {
        return this.posY;
    }
    
    public void setCantidadVida(int cantidadVida) {
        this.cantidadVida = cantidadVida;
    }

    public int getCantidadVida() {
        return this.cantidadVida;
    }

    public override string ToString() {
        return $"Enemigo [imagen = {imagen}, posX = {posX}, posY = {posY}, Cantidad De Vida = {cantidadVida}]";
    }

    public Enemigo clone() {
        return new Enemigo(this);
    }
}