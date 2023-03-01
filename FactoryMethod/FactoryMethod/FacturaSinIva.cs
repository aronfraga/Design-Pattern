namespace Patterns.FactoryMethod; 

public class FacturaSinIva : Factura {
    public override double Importe() {
        return getImporte();
    }
}