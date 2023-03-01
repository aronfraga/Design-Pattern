namespace Patterns.AbstracFactory; 

public class Gato : IAnimal {
    public string getAnimal() {
        return "Gato";
    }

    public string hacerSonido() {
        return "Miauu Miaauu";
    }
}