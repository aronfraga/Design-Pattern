namespace Patterns.Command2; 

public class TV : IDispositivo {
    private bool on;

    public TV() {
        this.on = false;
    }

    public void On() {
        this.on = true;
        Console.WriteLine("Tv Encendida!");
    }
    
    public void Off() {
        this.on = false;
        Console.WriteLine("Tv Apagada!");
    }
}