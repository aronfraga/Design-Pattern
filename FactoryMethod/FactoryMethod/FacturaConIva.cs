namespace Patterns.FactoryMethod; 

public class FacturaConIva : Factura {
    public override double Importe() {
        return getImporte() * 1.21;
    }
}