namespace Patterns; 

public class Juguetes : DecoradorArbolito {
    public Juguetes(IArbolitoNavidad arbolitoNavidad) : base(arbolitoNavidad) {
    }

    public override string Decorar() {
        return base.Decorar() + DecorarConJuguetes();
    }

    private string DecorarConJuguetes() {
        return " Con Juguetes";
    }
}