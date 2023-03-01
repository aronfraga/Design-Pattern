namespace Patterns.AbstracFactory; 

public class FactoryProvider {

    public static IAnimalFactory getFactory(string eleccion) {
        if ("Tierra".Equals(eleccion)) {
            return new TierraFactory();
        } else if ("Mar".Equals(eleccion)) {
            return new MarFactory();
        }

        return new TierraFactory();
    }
}