namespace Patterns.Facade; 

public class HotelApi {
    
    public void buscarHotel(string fechaEntrada, string fechaSalida, string origen, string destino) {
        Console.WriteLine("===================================");
        Console.WriteLine("Hoteles encontrados");
        Console.WriteLine("Entrada: " + fechaEntrada + " salida: " + fechaSalida);
        Console.WriteLine("Hotel A");
        Console.WriteLine("Hotel B");
        Console.WriteLine("Hotel C");
        Console.WriteLine("===================================");
    }
    
}