namespace Patterns; 

public class Guirnaldas : DecoradorArbolito {
    public Guirnaldas(IArbolitoNavidad arbolitoNavidad) : base(arbolitoNavidad) {
        
    }

    public override string Decorar() {
        return base.Decorar() + DecorarConGuirnaldas();
    }

    private string DecorarConGuirnaldas() {
        return " Con Guirnaldas";
    }
    
}