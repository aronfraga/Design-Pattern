namespace Strategy; 

public class Transaccion {

    private IEstrategia _estrategia;

    public Transaccion(IEstrategia estrategia) {
        _estrategia = estrategia;
    }

    public float ejecutarTransaccion(float balance, float cantidad) {
        return this._estrategia.realizarOperacion(balance, cantidad);
    }
    
}