namespace Prototype.Example2; 

public class CuentaAhorro : ICuenta {

    private string tipo;
    private double monto;

    public CuentaAhorro() {
        this.tipo = "AHORRO";
    }

    public object Clone() {
        throw new NotImplementedException();
    }

    public void setMonto(double monto) {
        this.monto = monto;
    }
    
    public double getMonto() {
        return monto;
    }

    public ICuenta clonar() {
        CuentaAhorro cuenta = null;
        
        try {
            cuenta = (CuentaAhorro) Clone();
        } catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }

        return cuenta;
    }

    public override string ToString() {
        return $"CuentaAhorro: [tipo = {tipo}, monto = {monto}]";
    }
    
    
}