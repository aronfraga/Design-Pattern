namespace Strategy; 

public class Deposito : IEstrategia {
    public float realizarOperacion(float balance, float cantidad) {
        return balance + cantidad;
    }
}