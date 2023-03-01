namespace Patterns.AbstracFactory; 

public class MarFactory : IAnimalFactory {
    public IAnimal crear(string tipoAnimal) {
        if ("Delfin".Equals(tipoAnimal)) {
            return new Delfin();
        }else if ("Lobo Marino".Equals(tipoAnimal)) {
            return new LoboMarino();
        }else if ("Foca".Equals(tipoAnimal)) {
            return new Foca();
        }

        return new Delfin();
    }
}