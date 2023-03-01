namespace Patterns.AbstracFactory; 

public class Oso : IAnimal {
    public string getAnimal() {
        return "Oso";
    }

    public string hacerSonido() {
        return "grrrrrrr";
    }
}