namespace Strategy; 

public class MostrarSaldo : IEstrategia {
    public float realizarOperacion(float balance, float cantidad) {
        return balance;
    }
}