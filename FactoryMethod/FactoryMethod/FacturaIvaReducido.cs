namespace Patterns.FactoryMethod; 

public class FacturaIvaReducido : Factura {
    public override double Importe() {
        return getImporte() * 1.05;
    }
}