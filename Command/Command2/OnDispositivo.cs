namespace Patterns.Command2; 

public class OnDispositivo : IComando {

    private IDispositivo _dispositivo;

    public OnDispositivo(IDispositivo dispositivo) {
        _dispositivo = dispositivo;
    }
    
    public void operacion() {
        _dispositivo.On();
    }
}