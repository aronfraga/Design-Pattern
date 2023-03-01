namespace Patterns; 

public class Estrallita : DecoradorArbolito, IArbolitoNavidad {
    public Estrallita(IArbolitoNavidad arbolitoNavidad) : base(arbolitoNavidad) {
        
    }

    override public string Decorar() {
        return base.Decorar() + DecorarConEstrellas();
    }

    private string DecorarConEstrellas() {
        return " Con Estrella";
    }
}