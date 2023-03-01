namespace Patterns;

public abstract class DecoradorArbolito : IArbolitoNavidad {

    private IArbolitoNavidad _arbolitoNavidad;

    public DecoradorArbolito(IArbolitoNavidad arbolitoNavidad) {
        _arbolitoNavidad = arbolitoNavidad;
    }
    
    public virtual string Decorar() {
        return _arbolitoNavidad.Decorar();
    }
}