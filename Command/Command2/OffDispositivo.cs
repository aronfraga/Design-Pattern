namespace Patterns.Command2;

public class OffDispositivo : IComando{

    private IDispositivo _dispositivo;

    public OffDispositivo(IDispositivo dispositivo) {
        _dispositivo = dispositivo;
    }
    
    public void operacion() {
        _dispositivo.Off();
    }
}