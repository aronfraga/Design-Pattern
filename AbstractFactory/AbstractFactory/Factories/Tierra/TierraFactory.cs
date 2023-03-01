namespace Patterns.AbstracFactory; 

public class TierraFactory : IAnimalFactory {
    public IAnimal crear(string tipoAnimal) {
        if ("Perro".Equals(tipoAnimal)) {
            return new Perro();
        }else if ("Gato".Equals(tipoAnimal)) {
            return new Gato();
        }else if ("Oso".Equals(tipoAnimal)) {
            return new Oso();
        }

        return new Perro();
    }
}