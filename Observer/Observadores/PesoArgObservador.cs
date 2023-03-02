namespace Observer; 

public class PesoArgObservador : Observador {
    
    private double valorCambio = 200;

    public PesoArgObservador(Sujeto sujeto) {
        this.sujeto = sujeto;
        this.sujeto.agregar(this); // hace referencia al PesosArgObservador 
    }

    public override void actualizar() {
        Console.WriteLine("Argentina: " + (sujeto.getEstado() * valorCambio));
    }
    
}