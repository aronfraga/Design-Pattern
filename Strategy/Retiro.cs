namespace Strategy; 

public class Retiro : IEstrategia {
    public float realizarOperacion(float balance, float cantidad) {
        return balance - cantidad;
    }
}