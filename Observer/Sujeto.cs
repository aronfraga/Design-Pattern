namespace Observer; 

public class Sujeto {

    private List<Observador> observadores = new List<Observador>();
    private int estado;

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
        notificarTodosLosObservadores();
    }

    private void notificarTodosLosObservadores() {
        observadores.ForEach(x => x.actualizar());
    }

    //subscripcion
    public void agregar(Observador observador) {
        observadores.Add(observador);
    }

}