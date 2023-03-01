namespace Patterns.FactoryMethod; 

public class FactoryFactura {

    public static Factura getFactura(string tipo) {
        if (tipo.Equals("IVA")) {
            return new FacturaConIva();
        } else if (tipo.Equals("IVA REDUCIDO")) {
            return new FacturaIvaReducido();
        } else {
            return new FacturaSinIva();
        }
    }
    
}