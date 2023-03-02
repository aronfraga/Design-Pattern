namespace Observer; 

public class EuroEspObservador : Observador {

    private double valorCambio = 1;

    public EuroEspObservador(Sujeto sujeto) {
        this.sujeto = sujeto;
        this.sujeto.agregar(this);
    }

    public override void actualizar() {
        Console.WriteLine("España: " + (sujeto.getEstado() * valorCambio));
    }
    
}