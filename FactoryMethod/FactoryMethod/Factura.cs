namespace Patterns.FactoryMethod; 

abstract public class Factura {
    
    private int id;
    private double importe;

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public double getImporte() {
        return importe;
    }

    public void setImporte(double importe) {
        this.importe = importe;
    }

    abstract public double Importe();

}