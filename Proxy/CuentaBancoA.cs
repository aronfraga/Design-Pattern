namespace Proxy; 

public class CuentaBancoA : ICuenta {
    
    public Cuenta retirarDinero(Cuenta cuenta, double monto) {
        double saldoActual = cuenta.getSaldoInicial() - monto;
        cuenta.setSaldoInicial(saldoActual);
        Console.WriteLine("Saldo actual: " + cuenta.getSaldoInicial());
        return cuenta;
    }

    public Cuenta depositarDinero(Cuenta cuenta, double monto) {
        double saldoActual = cuenta.getSaldoInicial() + monto;
        cuenta.setSaldoInicial(saldoActual);
        Console.WriteLine("Saldo actual: " + cuenta.getSaldoInicial());
        return cuenta;
    }

    public void mostrarSaldo(Cuenta cuenta) {
        Console.WriteLine("Saldo Actual: " + cuenta.getSaldoInicial());
    }
    
}