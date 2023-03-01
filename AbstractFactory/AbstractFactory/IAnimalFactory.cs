namespace Patterns.AbstracFactory; 

public interface IAnimalFactory {

    IAnimal crear(string tipoAnimal);
    
}