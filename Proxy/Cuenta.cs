namespace Proxy; 

//Modelo
public class Cuenta {

    private int IdCuenta;
    private string Usuario;
    private double SaldoInicial;

    public Cuenta() {
        
    }

    public Cuenta(int idCuenta, string usuario, double saldoInicial) {
        IdCuenta = idCuenta;
        Usuario = usuario;
        SaldoInicial = saldoInicial;
    }
    
    public Cuenta(string usuario, double saldoInicial) {
        Usuario = usuario;
        SaldoInicial = saldoInicial;
    }
    
    public int getIdCuenta() {
        return IdCuenta;
    }
    
    public void setIdCuenta(int id) {
        IdCuenta = id;
    }
    
    public string getUsuario() {
        return Usuario;
    }
    
    public void setUsuario(string usuario) {
        Usuario = usuario;
    }
    
    public double getSaldoInicial() {
        return SaldoInicial;
    }
    
    public void setSaldoInicial(double saldoInicial) {
        SaldoInicial = saldoInicial;
    }
    
    
}