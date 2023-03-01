namespace Patterns.AbstracFactory; 

public class Perro : IAnimal {
    public string getAnimal() {
        return "Perro";
    }

    public string hacerSonido() {
        return "Uaah uaah";
    }
}