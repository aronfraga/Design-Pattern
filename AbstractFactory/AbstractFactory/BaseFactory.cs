namespace Patterns.AbstracFactory; 

public class BaseFactory {

    public static IAnimalFactory getFactory(string eleccion) {
        if ("Tierra".Equals(eleccion)) {
            return new TierraFactory();
        } else if ("Mar".Equals(eleccion)) {
            return new MarFactory();
        } else {
            return new TierraFactory();
        }
    }
    
}