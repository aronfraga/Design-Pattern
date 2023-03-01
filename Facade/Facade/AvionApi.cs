namespace Patterns.Facade; 

public class AvionApi {
    
    public void buscarVuelos(string fechaIda, string fechaVuelta, string origen, string destino) {
        Console.WriteLine("===================================");
        Console.WriteLine("Vuelos encontrados para " + destino + " desde " + origen);
        Console.WriteLine("Fecha ida: " + fechaIda + " Fecha vuelta " + fechaVuelta);
        Console.WriteLine("===================================");
    }
    
}