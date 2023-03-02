namespace Observer; 

public class PesoMexObservador : Observador {
    
    private double valorCambio = 18.12;

    public PesoMexObservador(Sujeto sujeto) {
        this.sujeto = sujeto;
        this.sujeto.agregar(this); // hace referencia al PesoMexObservador
    }

    public override void actualizar() {
        Console.WriteLine("Mexicano: " + (sujeto.getEstado() * valorCambio));
    }
    
}