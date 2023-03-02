namespace Proxy; 

//proxy intermedio
public class CuentaProxy : ICuenta {

    private ICuenta cuentaReal;

    public CuentaProxy(ICuenta cuentaReal) {
        this.cuentaReal = cuentaReal;
    }

    public Cuenta retirarDinero(Cuenta cuenta, double monto) {
        Console.WriteLine("--------- Cuenta Proxy - Retirar Dinero ----------");
        if (cuentaReal == null) {
            cuentaReal = new CuentaBancoA();
            return cuentaReal.retirarDinero(cuenta, monto);
        } else {
            return cuentaReal.retirarDinero(cuenta, monto);
        }
    }

    public Cuenta depositarDinero(Cuenta cuenta, double monto) {
        Console.WriteLine("--------- Cuenta Proxy - Depositar Dinero ----------");
        if (cuentaReal == null) {
            cuentaReal = new CuentaBancoA();
            return cuentaReal.depositarDinero(cuenta, monto);
        } else {
            return cuentaReal.depositarDinero(cuenta, monto);
        }
    }

    public void mostrarSaldo(Cuenta cuenta) {
        if (cuentaReal == null) {
            cuentaReal = new CuentaBancoA();
            cuentaReal.mostrarSaldo(cuenta);
        } else {
            cuentaReal.mostrarSaldo(cuenta);
        }
    }
    
}